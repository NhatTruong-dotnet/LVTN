import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
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
    selectWishList,
} from '../../features/Post/PostSlice'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

const array = [
    {
        idBaiDang: 1,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 2,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 3,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 4,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
]
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
                    style={{ maxHeight: '100vh' }}
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
    const postDetail = useSelector(selectPostDetail)
    const wishList = useSelector(selectWishList)
    const isLoading = useSelector(selectPendingStatusPost)

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

    useEffect(() => {
        if (idPost) {
            dispatch({ type: 'getPostDetail', idPost })
        }
    }, [idPost])

    if (isEmptyObject(postDetail)) {
        return ''
    }
    console.log(renderDetailObject(postDetail.result.detail))

    return (
        <div className='grid wide'>
            <DynamicModal showModal={isLoading} loading />
            <Frame>
                <div className='row'>
                    <div className='col l-8'>
                        <Carousel infiniteLoop={true}>
                            {renderImage(postDetail.result.HinhAnh)}
                            {renderVideo(postDetail.result.Video)}
                            {/* <div>
                                <img src='https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg' />
                            </div>
                            <div>
                                <img src='https://cdn.chotot.com/wDhwB8UnRJIW3-hSafZC309nZvZu1ROnP57NXar0bZo/preset:view/plain/88bc6137e3970fe54b869df9212c9715-2772334569845266749.jpg' />
                            </div>
                            <div>
                                <img src='https://cdn.chotot.com/xjwkhUb5gwnTX0GE-eKx9KQlbiWLy7XaVXg9xGvqO3E/preset:view/plain/84a5bc5f3376ca291470115100af1766-2772334573301975305.jpg' />
                            </div> */}
                        </Carousel>

                        <div className={styles.detailContainer}>
                            <div className={styles.title}>
                                {postDetail.result.BaiDang.tieuDe}
                            </div>
                            <div className={styles.price}>
                                {postDetail.result.BaiDang.gia}
                            </div>
                            <div className={styles.description}>
                                {postDetail.result.BaiDang.moTa}
                            </div>
                            <div className={styles.numberPhone}>
                                Liên hệ: {postDetail.result.BaiDang.sdt}
                            </div>
                            <div
                                className={styles.savePost}
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
                            <div className={styles.avatar}>
                                <FaUserCircle />
                            </div>
                            <div className={styles.name}>Nguyễn Trọng Trí</div>
                            <div
                                className={clsx(styles.savePost, styles.small)}
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
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                        </div>
                    </div>
                </div>
            </Frame>
            <Frame title='Tin đăng tương tự'>
                {/* <ListPost listPost={array} /> */}
            </Frame>
        </div>
    )
}

export default Detail
