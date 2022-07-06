import React from 'react'
import styles from './post.module.css'
import { ImUserTie } from 'react-icons/im'
import { useNavigate, useParams } from 'react-router-dom'
import { FaRegHeart } from 'react-icons/fa'
import { HiDotsVertical } from 'react-icons/hi'
import { useDispatch, useSelector } from 'react-redux'
import {
    removeItemWishList,
    addWishList,
    selectWishList,
} from '../../../features/Post/PostSlice'
import clsx from 'clsx'
import { formatCurrency } from '../../../Utils/formatCurrency'
import { useState } from 'react'
import TabContainer from '../../../Common/TabContainer'
import { selectNumberPhone } from '../../../features/Auth/Login/loginSlice'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function HorizontalPost({
    idPost,
    title,
    price,
    createdDate,
    imgId,
    location,
    authorName,
    isMyPost,
    empty,
    status,
}) {
    const navigate = useNavigate()
    const dispatch = useDispatch()
    const wishList = useSelector(selectWishList)
    const { profileUserNumberPhone } = useParams()
    const loginUserNumberPhone = useSelector(selectNumberPhone)

    const redirectToDetailPage = () => {
        navigate(`/detail/${idPost}`)
    }
    const handleWishList = e => {
        e.stopPropagation()
        if (checkSavedPost(idPost)) {
            dispatch(removeItemWishList(idPost))
        } else {
            dispatch(
                addWishList({
                    idPost,
                    title,
                    price,
                    createdDate,
                    location,
                    authorName,
                    imgId,
                })
            )
        }
    }
    const checkSavedPost = id => {
        if (!wishList) return
        const findPost = wishList.find(({ idPost }) => id === idPost)
        return Boolean(findPost)
    }
    if (empty) {
        return (
            <div
                style={{
                    height: 200,
                    display: 'flex',
                    justifyContent: 'center',
                    alignItems: 'center',
                    fontSize: 30,
                    fontWeight: 700,
                }}
            >
                <div>Bạn chưa có bài đăng yêu thích nào</div>
            </div>
        )
    }

    return (
        <div className={styles.horizontalPost} onClick={redirectToDetailPage}>
            {!isMyPost && (
                <div
                    className={clsx(styles.savePost, {
                        [styles.saved]: checkSavedPost(idPost),
                    })}
                    onClick={handleWishList}
                >
                    {checkSavedPost(idPost) ? 'Đã lưu' : 'Lưu tin'}
                    <FaRegHeart className={styles.icon} />
                </div>
            )}
            <img
                src={`${imgURL}${imgId}`}
                alt={title}
                className={styles.background}
            />
            <div className={styles.postDetail}>
                <div className={styles.title}>{title}</div>
                <div className={styles.price}>{formatCurrency(price)}</div>
                <div className={styles.moreInfo}>
                    <ImUserTie />

                    <div className={styles.dot}></div>
                    <div className={styles.time}>{createdDate}</div>
                    <div className={styles.dot}></div>
                    <div className={styles.location}>{location}</div>
                </div>
            </div>
            {loginUserNumberPhone === profileUserNumberPhone ? (
                <PostControl status={status} idPost={idPost} />
            ) : (
                ''
            )}
        </div>
    )
}

function PostControl({ status, idPost }) {
    const [showControl, setShowControl] = useState(false)
    const dispatch = useDispatch()

    const handleSetActivePost = active => {
        dispatch({ type: 'setActivePost', active, idPost, statusTab: status })
    }

    return (
        <>
            <HiDotsVertical
                style={{ position: 'absolute', right: 10, fontSize: 20 }}
                onClick={e => {
                    e.stopPropagation()
                    setShowControl(true)
                }}
            />
            {showControl && (
                <TabContainer onClickOutside={() => setShowControl(false)}>
                    <div className={styles.control}>
                        {status === '4' ? (
                            <div
                                className={styles.controlItem}
                                onClick={e => {
                                    e.stopPropagation()
                                    setShowControl(false)
                                    handleSetActivePost(false)
                                }}
                            >
                                Hiện tin
                            </div>
                        ) : (
                            <div
                                className={styles.controlItem}
                                onClick={e => {
                                    e.stopPropagation()
                                    setShowControl(false)
                                    handleSetActivePost(true)
                                }}
                            >
                                Ẩn tin
                            </div>
                        )}
                        <div className={styles.controlItem}>Chỉnh sửa tin</div>
                    </div>
                </TabContainer>
            )}
        </>
    )
}

export default HorizontalPost
