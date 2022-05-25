import React from 'react'
import styles from './post.module.css'
import TimeAgo from 'javascript-time-ago'
import { ImUserTie } from 'react-icons/im'
import { useNavigate } from 'react-router-dom'
import { FaRegHeart } from 'react-icons/fa'
import { useDispatch } from 'react-redux'
import {
    removeItemWishList,
    addWishList,
} from '../../../features/Post/PostSlice'
import clsx from 'clsx'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function HorizontalPost({
    idPost,
    title,
    price,
    createdDate,
    imgId,
    location,
    authorName,
    saved,
    wishList,
}) {
    const timeAgo = new TimeAgo('en-US')
    const navigate = useNavigate()
    const dispatch = useDispatch()

    const redirectToDetailPage = () => {
        navigate(`/detail/${idPost}`)
    }
    const handleWishList = () => {
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

    return (
        <div className={styles.horizontalPost} onClick={redirectToDetailPage}>
            <div
                className={clsx(styles.savePost, styles.saved)}
                onClick={handleWishList}
            >
                {checkSavedPost(idPost) ? 'Đã lưu' : 'Lưu tin'}
                <FaRegHeart className={styles.icon} />
            </div>
            <img
                // src='https://cdn.chotot.com/l6nzMpYlbv1VCXs2iIFUbVfIU62JpKQUZdcwhjzwDRU/preset:listing/plain/98ef2bd9efc5371aae2340d37bad701e-2768418666813430784.jpg'
                src={`${imgURL}${imgId}`}
                alt={title}
                className={styles.background}
            />
            <div className={styles.postDetail}>
                <div className={styles.title}>{title}</div>
                <div className={styles.price}>{price}</div>
                <div className={styles.moreInfo}>
                    <ImUserTie />

                    <div className={styles.dot}></div>
                    <div className={styles.time}>
                        {createdDate && timeAgo.format(createdDate)}
                    </div>
                    <div className={styles.dot}></div>
                    <div className={styles.location}>{location}</div>
                </div>
            </div>
        </div>
    )
}

export default HorizontalPost
