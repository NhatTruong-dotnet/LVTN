import Home from './Page/Home'
import Header from './Base/Header'
import { Routes, Route } from 'react-router-dom'
import CreatePost from './Page/CreatePost'
import ToastMessage from './Common/ToastMessage/ToastMessage'
import { useEffect } from 'react'
import { useDispatch } from 'react-redux'
import { loginWithToken } from './features/Auth/Login/loginSlice'
import Detail from './Page/Detail/Detail'
import WishList from './Page/WishList/WishList'
import { getWishList } from './features/Post/PostSlice'
import ProfileUser from './Page/ProfileUser/ProfileUser'

function App() {
    const dispatch = useDispatch()

    // init wish list
    useEffect(() => {
        const wishList = JSON.parse(localStorage.getItem('wishList'))
        if (!Array.isArray(wishList)) {
            localStorage.setItem('wishList', JSON.stringify([]))
        }
    }, [])

    useEffect(() => {
        dispatch(getWishList())
    }, [])

    useEffect(() => {
        dispatch(loginWithToken())
    }, [])
    return (
        <div>
            <Header />

            <div style={{ marginTop: 90 }}></div>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/create-post' element={<CreatePost />} />
                <Route path='/detail/:idPost' element={<Detail />} />
                <Route path='/wish-list' element={<WishList />} />
                <Route
                    path='/user/:profileUserNumberPhone'
                    element={<ProfileUser />}
                />
            </Routes>
            <ToastMessage />
        </div>
    )
}

export default App
