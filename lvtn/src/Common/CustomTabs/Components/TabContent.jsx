import { useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import Loading from '../../../Common/Loading/Loading'
import {
    selectPendingStateUserPost,
    selectUserPost,
} from '../../../features/User/UserSlice'
import EmptyPost from '../../EmptyPost/EmptyPost'
import HorizontalPost from '../../ListPost/Post/HorizontalPost'

function TabContent({ status, profileUserNumberPhone, loginUserNumberPhone }) {
    const isLoading = useSelector(selectPendingStateUserPost)
    const userPosts = useSelector(selectUserPost)
    const dispatch = useDispatch()

    useEffect(() => {
        dispatch({
            type: 'getUserPostWithStatus',
            postStatus: status,
        })
    }, [status])

    if (isLoading) return <Loading height={300} />
    else if (userPosts.length === 0) {
        return <EmptyPost height={300} />
    }

    return (
        <div>
            {userPosts.map(
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
                        status={status}
                    />
                )
            )}
        </div>
    )
}

export default TabContent
