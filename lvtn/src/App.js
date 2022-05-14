import Home from './Page/Home'
import Header from './Base/Header'
import { Routes, Route, Link } from 'react-router-dom'
import CreatePost from './Page/CreatePost'

function App() {
    // console.log(process.env.REACT_APP_BASE_IMG_URL)
    return (
        <div>
            <Header />

            <div style={{ marginTop: 90 }}></div>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/create-post' element={<CreatePost />} />
            </Routes>
        </div>
    )
}

export default App
