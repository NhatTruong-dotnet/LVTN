import Frame from '../../Common/Frame/Frame'
import styles from './wishList.module.css'
import HorizontalPost from '../../Common/ListPost/Post/HorizontalPost'
import { useSelector } from 'react-redux'
import { selectWishList } from '../../features/Post/PostSlice'
import { useEffect } from 'react'

function WishList(props) {
    const wishList = useSelector(selectWishList)
    useEffect(() => {
        document.title = 'Tin yêu thích'
        return () => (document.title = 'STU')
    }, [])

    return (
        <div className='grid wide'>
            <Frame title={`Tin đăng đã lưu ${wishList.length}/100`}>
                <div className={styles.WishListContainer}>
                    {wishList.length ? (
                        ''
                    ) : (
                        <HorizontalPost empty></HorizontalPost>
                    )}
                    {wishList.map(
                        ({
                            idPost,
                            authorName,
                            createdDate,
                            imgId,
                            location,
                            price,
                            title,
                        }) => (
                            <HorizontalPost
                                key={idPost}
                                idPost={idPost}
                                authorName={authorName}
                                createdDate={createdDate}
                                imgId={imgId}
                                location={location}
                                price={price}
                                title={title}
                                wishList={wishList}
                            />
                        )
                    )}
                </div>
            </Frame>
        </div>
    )
}

export default WishList
