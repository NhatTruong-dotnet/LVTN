import Post from './Post/Post'

import styles from './listPost.module.css'

function ListPost({ listPost = [] }) {
    return (
        <div className={styles.listPost}>
            {listPost.map(
                (
                    { idBaiDang, tieuDe, idHinhAnh, gia, ngayTao, thanhPho },
                    index
                ) => (
                    <Post
                        key={idBaiDang}
                        id={idBaiDang}
                        title={tieuDe}
                        price={gia}
                        imgId={idHinhAnh}
                        createdDate={ngayTao}
                        location={thanhPho}
                    />
                )
            )}
        </div>
    )
}

export default ListPost
