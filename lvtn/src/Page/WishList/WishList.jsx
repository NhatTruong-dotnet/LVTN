import Frame from '../../Common/Frame/Frame'
import styles from './wishList.module.css'
import HorizontalPost from '../../Common/ListPost/Post/HorizontalPost'
import { useSelector } from 'react-redux'
import { selectWishList } from '../../features/Post/PostSlice'

function WishList(props) {
    const wishList = useSelector(selectWishList)
    console.log(wishList)

    return (
        <div className='grid wide'>
            <Frame title={'Tin đăng đã lưu'}>
                <div className={styles.WishListContainer}>
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
                    {/* <HorizontalPost /> */}
                </div>
            </Frame>
        </div>
    )
}

export default WishList
