import React, { useEffect, useState } from 'react'
import { Navigate, useNavigate, useParams } from 'react-router-dom'
import 'react-responsive-carousel/lib/styles/carousel.min.css'
import { Carousel } from 'react-responsive-carousel'
import styles from './detail.module.css'
import { FaRegHeart, FaUserCircle } from 'react-icons/fa'
import { GoLocation } from 'react-icons/go'
import Frame from '../../Common/Frame/Frame'
import ListPost from '../../Common/ListPost/ListPost'
import clsx from 'clsx'
import { useDispatch, useSelector } from 'react-redux'
import {
    addWishList,
    removeItemWishList,
    selectPendingStatusPost,
    selectPostDetail,
    selectRelatedPost,
    selectWishList,
} from '../../features/Post/PostSlice'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'
import { formatCurrency } from '../../Utils/formatCurrency'
import { Button } from 'reactstrap'
import { setReceiveUserInfo } from '../../features/Chat/ChatSlice'
import { selectNumberPhone } from '../../features/Auth/Login/loginSlice'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function isEmptyObject(obj) {
    return Object.keys(obj).length === 0
}

function renderDetailObject(obj) {
    const jsx = []
    for (let key in obj) {
        jsx.push(
            <div className={styles.detailItem} key={key}>
                <span style={{ fontWeight: 550 }}>{key}</span> {obj[key]}
            </div>
        )
    }
    return jsx
}
function renderImage(obj) {
    const imageJsx = []
    for (let key in obj) {
        imageJsx.push(
            <div key={key}>
                <img
                    src={`${imgURL}${obj[key]}`}
                    style={{ maxHeight: '500px', objectFit: 'contain' }}
                />
            </div>
        )
    }
    return imageJsx
}
function renderVideo(obj) {
    const videoJsx = []
    for (let key in obj) {
        videoJsx.push(
            <div key={key}>
                <video
                    src={`${imgURL}${obj[key]}`}
                    style={{ maxHeight: '100vh' }}
                ></video>
            </div>
        )
    }
    return videoJsx
}

function Detail(props) {
    const { idPost } = useParams()
    const dispatch = useDispatch()
    const navigate = useNavigate()
    const postDetail = useSelector(selectPostDetail)
    const relatedPost = useSelector(selectRelatedPost)
    const wishList = useSelector(selectWishList)
    const isLoading = useSelector(selectPendingStatusPost)
    const loginUserSdt = useSelector(selectNumberPhone)

    console.log(postDetail.userProfile)
    const handleWishList = () => {
        if (checkSavedPost(idPost)) {
            dispatch(removeItemWishList(idPost))
        } else {
            dispatch(
                addWishList({
                    idPost,
                    title: postDetail.result.BaiDang.tieuDe,
                    price: postDetail.result.BaiDang.gia,
                    createdDate: '',
                    location: postDetail.result.BaiDang.khuVuc,
                    authorName: postDetail.result.BaiDang.sdt,
                    imgId: postDetail.result.HinhAnh['1'],
                })
            )
        }
    }

    const checkSavedPost = id => {
        if (!wishList) return
        const findPost = wishList.find(({ idPost }) => id === idPost)
        return Boolean(findPost)
    }

    const handleCreateConversation = () => {
        dispatch(
            setReceiveUserInfo({
                userInfo: postDetail.userProfile,
            })
        )
        navigate('/chat')
    }

    useEffect(() => {
        if (idPost) {
            dispatch({ type: 'getPostDetail', idPost })
        }
    }, [idPost])

    useEffect(() => {
        dispatch({ type: 'getRelatedPost', categoryId: 0 })
    }, [])

    if (isEmptyObject(postDetail)) {
        return ''
    }

    return (
        <div className='grid wide'>
            <DynamicModal showModal={isLoading} loading />
            <Frame>
                <div className='row'>
                    <div className='col l-8'>
                        <Carousel infiniteLoop={true}>
                            {renderImage(postDetail.result.HinhAnh)}
                            {renderVideo(postDetail.result.Video)}
                        </Carousel>

                        <div className={styles.detailContainer}>
                            <div className={styles.title}>
                                {postDetail.result.BaiDang.tieuDe}
                            </div>
                            <div className={styles.price}>
                                {postDetail.result.BaiDang.gia &&
                                    formatCurrency(
                                        postDetail.result.BaiDang.gia
                                    )}
                            </div>
                            <div className={styles.description}>
                                {postDetail.result.BaiDang.moTa}
                            </div>
                            <div className={styles.numberPhone}>
                                Liên hệ: {postDetail.result.BaiDang.sdt}
                            </div>
                            <div
                                className={clsx(styles.savePost, {
                                    [styles.saved]: checkSavedPost(idPost),
                                })}
                                onClick={handleWishList}
                            >
                                {checkSavedPost(idPost) ? 'Đã lưu' : 'Lưu tin'}{' '}
                                <FaRegHeart className={styles.icon} />
                            </div>

                            <div className={styles.detail}>
                                {renderDetailObject(postDetail.result.detail)}
                            </div>
                            <div className={styles.subTitle}>Khu vực</div>
                            <div className={styles.address}>
                                <GoLocation className={styles.addressIcon} />
                                {postDetail.result.BaiDang.khuVuc}
                            </div>
                        </div>
                    </div>

                    <div className='col l-4'>
                        <div className={styles.vendorInfo}>
                            {postDetail?.userProfile.anhDaiDienSource ? (
                                <img
                                    src={
                                        postDetail?.userProfile.anhDaiDienSource
                                    }
                                    alt='avatar'
                                    width={60}
                                    height={60}
                                    style={{
                                        borderRadius: 100,
                                        marginRight: 10,
                                    }}
                                />
                            ) : (
                                <div className={styles.avatar}>
                                    <FaUserCircle />
                                </div>
                            )}

                            <div className={styles.name}>
                                {postDetail?.userProfile?.ten}
                            </div>
                            <div
                                className={clsx(styles.savePost, styles.small)}
                                onClick={() =>
                                    navigate(
                                        `/user/${postDetail.result.BaiDang.sdt}`
                                    )
                                }
                            >
                                Xem trang
                            </div>
                        </div>
                        <div className={styles.moreInfoVendor}>
                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                            <div className={styles.line}></div>
                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                            <div className={styles.line}></div>

                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>
                                    Đánh giá hệ thống
                                </div>
                                <div className={styles.infoValue}>
                                    {postDetail?.userProfile?.danhGiaHeThong ||
                                        'Chưa có đánh giá'}
                                </div>
                            </div>
                        </div>
                        {postDetail.userProfile === loginUserSdt ? (
                            ''
                        ) : (
                            <Button
                                color='primary'
                                className='mt-5'
                                block
                                onClick={handleCreateConversation}
                            >
                                Nhắn tin với người bán
                            </Button>
                        )}
                    </div>
                </div>
            </Frame>
            <Frame title='Tin đăng tương tự'>
                <ListPost listPost={relatedPost} />
            </Frame>
        </div>
    )
}

export default Detail
