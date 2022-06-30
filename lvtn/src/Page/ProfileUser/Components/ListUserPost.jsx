import { useSelector } from 'react-redux'
import EmptyPost from '../../../Common/EmptyPost/EmptyPost'
import Loading from '../../../Common/Loading/Loading'
import {
    selectPendingStateUserPost,
    selectUserPost,
} from '../../../features/User/UserSlice'
import HorizontalPost from '../../../Common/ListPost/Post/HorizontalPost'

function ListUserPost({ profileUserNumberPhone, loginUserNumberPhone }) {
    const userPost = useSelector(selectUserPost)
    const isLoading = useSelector(selectPendingStateUserPost)
    if (isLoading) {
        return <Loading height={300} />
    } else if (userPost.length === 0) {
        return <EmptyPost height={300} />
    }

    return (
        <>
            {userPost.map(
                ({ tieuDe, idHinhAnh, gia, ngayTao, thanhPho, idBaiDang }) => (
                    <HorizontalPost
                        key={idBaiDang}
                        idPost={idBaiDang}
                        title={tieuDe}
                        price={gia}
                        imgId={idHinhAnh}
                        location={thanhPho}
                        createdDate={ngayTao}
                        isMyPost={
                            loginUserNumberPhone === profileUserNumberPhone
                        }
                    />
                )
            )}
        </>
    )
}

export default ListUserPost
