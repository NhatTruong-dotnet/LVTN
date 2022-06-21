import styles from './header.module.css'
import { SiEventstore } from 'react-icons/si'
import { FiEdit } from 'react-icons/fi'
import { AiOutlineUser, AiOutlineSearch } from 'react-icons/ai'
import clsx from 'clsx'
import AutoComplete from './Components/AutoComplete'
import { useEffect, useState } from 'react'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'

import AuthForm from './Components/AuthForm/AuthForm'
import UserControl from './Components/UserControl'
import Notification from './Components/Notification'
import { useLocation, useNavigate } from 'react-router-dom'
import { useSelector, useDispatch } from 'react-redux'
import {
    selectLoginStatus,
    selectNumberPhone,
    selectStatus,
    selectUsername,
} from '../../features/Auth/Login/loginSlice'
import ChatNotify from './Components/ChatNotify/ChatNotify'
import { addNewNotify } from '../../features/Notify/NotifySlice'

function Header(props) {
    const [searchValue, setSearchValue] = useState('')
    const [isShowAutoComplete, setIsShowAutoComplete] = useState(false)
    const [isShowForm, setIsShowForm] = useState(false)
    const isLoading = useSelector(selectStatus)
    const username = useSelector(selectUsername)
    const sdt = useSelector(selectNumberPhone)
    const isLogin = useSelector(selectLoginStatus)
    const dispatch = useDispatch()
    // const {pathname} = useLocation()

    const navigate = useNavigate()

    const handleSearchInputChange = e => {
        setIsShowAutoComplete(Boolean(e.target.value))
        setSearchValue(e.target.value)
    }

    const handleSearch = e => {
        e.preventDefault()
        navigate(`/search/${searchValue}`)
    }

    // close form if login success
    useEffect(() => {
        if (isLogin) {
            setIsShowForm(false)
        }
    }, [isLogin])

    useEffect(() => {
        if (window.notifyConnection) {
            window.notifyListen('ClientReceiveNotify', notify => {
                dispatch(addNewNotify({ newNotify: notify }))
            })
        }
    }, [window.notifyConnection])

    return (
        <div className={styles.container}>
            <div className='grid wide'>
                <div className={styles.wrap}>
                    <span className={styles.logo} onClick={() => navigate('/')}>
                        <SiEventstore className={styles.icon} />
                        {/* 𝓣𝓣𝓝𝓣 */}
                        STU
                    </span>
                    <form className={styles.searchForm} onSubmit={handleSearch}>
                        <AiOutlineSearch className={styles.searchIcon} />
                        <div className='searchGroup'>
                            <input
                                type='text'
                                placeholder='Tìm kiếm'
                                className={styles.searchInput}
                                value={searchValue}
                                onChange={handleSearchInputChange}
                                onBlur={() => setIsShowAutoComplete(false)}
                                onFocus={() =>
                                    setIsShowAutoComplete(Boolean(searchValue))
                                }
                            />
                            {isShowAutoComplete && (
                                <AutoComplete
                                    searchValue={searchValue}
                                    isShow={isShowAutoComplete}
                                />
                            )}
                        </div>
                    </form>
                    <div className={styles.userControl}>
                        {isLogin ? (
                            <>
                                <ChatNotify />

                                <UserControl username={username} sdt={sdt} />
                                <Notification />
                            </>
                        ) : (
                            <button
                                className={clsx(
                                    styles.popupLoginForm,
                                    styles.button
                                )}
                                onClick={() => setIsShowForm(true)}
                            >
                                <AiOutlineUser className={styles.buttonIcon} />
                                Đăng nhập
                            </button>
                        )}
                        <button
                            className={clsx(styles.button)}
                            onClick={() => {
                                if (isLogin) {
                                    navigate('create-post')
                                } else {
                                    setIsShowForm(true)
                                }
                            }}
                        >
                            <FiEdit className={styles.buttonIcon} />
                            Đăng tin
                        </button>
                    </div>
                </div>
            </div>
            <DynamicModal showModal={isShowForm} loading={isLoading}>
                <AuthForm setIsShowForm={setIsShowForm} />
            </DynamicModal>
        </div>
    )
}

export default Header
