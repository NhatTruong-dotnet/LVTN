import Post from './Post/Post'

import styles from './listPost.module.css'

function ListPost({ listPost = [] }) {
    return (
        <div className={styles.listPost}>
            {listPost.map(({ _id, title, price, img }) => (
                <Post
                    key={_id}
                    id={_id}
                    title={title}
                    price={price}
                    imgSrc={img[0]}
                />
            ))}
        </div>
    )
}

export default ListPost
