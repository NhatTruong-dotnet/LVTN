import React from 'react'
import styles from './post.module.css'
import { ImUserTie } from 'react-icons/im'
import { useNavigate } from 'react-router-dom'
import { FaRegHeart } from 'react-icons/fa'
import { useDispatch, useSelector } from 'react-redux'
import {
    removeItemWishList,
    addWishList,
    selectWishList,
} from '../../../features/Post/PostSlice'
import clsx from 'clsx'
import { formatCurrency } from '../../../Utils/formatCurrency'

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
}) {
    const navigate = useNavigate()
    const dispatch = useDispatch()
    const wishList = useSelector(selectWishList)

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
        </div>
    )
}

export default HorizontalPost
