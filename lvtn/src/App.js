import Header from './Base/Header'
import { Routes, Route, useLocation } from 'react-router-dom'
import { lazy, useEffect, useState } from 'react'
import { useDispatch } from 'react-redux'
import { loginWithToken } from './features/Auth/Login/loginSlice'
import { getWishList } from './features/Post/PostSlice'
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr'
import ToastMessage, { emitMessage } from './Common/ToastMessage/ToastMessage'
const Home = lazy(() => import('./Page/Home'))
const CreatePost = lazy(() => import('./Page/CreatePost'))
const Detail = lazy(() => import('./Page/Detail/Detail'))
const WishList = lazy(() => import('./Page/WishList/WishList'))
const ProfileUser = lazy(() => import('./Page/ProfileUser/ProfileUser'))
const EditProfileUser = lazy(() => import('./Page/ProfileUser/EditProfileUser'))
const Chat = lazy(() => import('./Page/Chat/Chat'))
const Category = lazy(() => import('./Page/Category/Category'))
const Search = lazy(() => import('./Page/Search/Search'))

function App() {
    const [connection, setConnection] = useState(null)
    const [notifyConnection, setNotifyConnection] = useState(null)
    const dispatch = useDispatch()
    const { pathname } = useLocation()

    const connectSignalRServer = async (
        url,
        setConnection,
        callbackOnConnectionClose
    ) => {
        const connection = new HubConnectionBuilder()
            .withUrl(url)
            .configureLogging(LogLevel.Information)
            .build()

        connection.onclose = e => {
            setConnection(null)
        }

        await connection.start()
        setConnection(connection)
    }

    const listen = (eventName, callback) => {
        if (connection) {
            connection.on(eventName, res => {
                callback(res)
            })
        }
    }

    const invokeMethod = async (method, data) => {
        try {
            await connection.invoke(method, data)
        } catch (e) {
            console.log(e)
        }
    }

    const closeConnection = async () => {
        try {
            await connection.stop()
        } catch (e) {
            console.log(e)
        }
    }

    const receiveMessage = message => {
        if (pathname !== '/chat') {
            emitMessage(
                'success',
                `Bạn có tin nhắn mới từ ${message.MessageBy}`
            )
        }
        dispatch({ type: 'ReceiveMessage', message })
    }

    const receiveNotify = notifyObject => {
        console.log(notifyObject)
    }
    // init wish list
    useEffect(() => {
        const wishList = JSON.parse(localStorage.getItem('wishList'))
        if (!Array.isArray(wishList)) {
            localStorage.setItem('wishList', JSON.stringify([]))
        }
    }, [])

    // get wish list
    useEffect(() => {
        dispatch(getWishList())
    }, [])

    // login with token
    useEffect(() => {
        dispatch(loginWithToken())
    }, [])

    // connect signalR
    useEffect(() => {
        connectSignalRServer('https://localhost:7298/chat', setConnection)
        connectSignalRServer(
            'https://localhost:7298/notify',
            setNotifyConnection
        )
    }, [])

    // set global signalR notify method
    useEffect(() => {
        window.notifyConnection = connection
        window.notifyInvokeMethod = invokeMethod
        window.notifyListen = listen
    }, [notifyConnection])

    // set global signalR chat method
    useEffect(() => {
        window.connection = connection
        window.invokeMethod = invokeMethod
        window.listen = listen
    }, [connection])

    useEffect(() => {
        if (connection) {
            listen('ReceiveMessage', receiveMessage)
            listen('ClientReceiveNotify', receiveNotify)
        }
        return () => {
            if (connection) {
                connection.off('ReceiveMessage')
                connection.off('ClientReceiveNotify')
            }
        }
    }, [connection])

    return (
        <div>
            <Header />

            <div style={{ marginTop: 90 }}></div>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/create-post' element={<CreatePost />} />
                <Route
                    path={`/edit-post/:idPost&:preflightKey`}
                    element={<CreatePost />}
                />
                <Route path='/detail/:idPost' element={<Detail />} />
                <Route path='/wish-list' element={<WishList />} />
                <Route
                    path='/user/:profileUserNumberPhone'
                    element={<ProfileUser />}
                />
                <Route
                    path='/user/edit-profile/:profileUserNumberPhone'
                    element={<EditProfileUser />}
                />
                <Route path='/chat' element={<Chat />} />
                <Route path='/category/:categoryId' element={<Category />} />
                <Route path='/search/:searchValue' element={<Search />} />
            </Routes>
            <ToastMessage />
        </div>
    )
}

export default App
