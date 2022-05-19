import Home from './Page/Home'
import Header from './Base/Header'
import { Routes, Route } from 'react-router-dom'
import CreatePost from './Page/CreatePost'
import ToastMessage from './Common/ToastMessage/ToastMessage'
import { useEffect } from 'react'
import { useDispatch } from 'react-redux'
import { loginWithToken } from './features/Auth/Login/loginSlice'

function App() {
    const dispatch = useDispatch()

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
            </Routes>
            <ToastMessage />
        </div>
    )
}

export default App
