import styles from './header.module.css'
import { SiEventstore } from 'react-icons/si'
import { FiEdit } from 'react-icons/fi'
import { AiOutlineUser, AiOutlineSearch } from 'react-icons/ai'
import clsx from 'clsx'
import AutoComplete from './Components/AutoComplete'
import { useState } from 'react'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'

import AuthForm from './Components/AuthForm/AuthForm'
import UserControl from './Components/UserControl'
import Notification from './Components/Notification'
import { useNavigate } from 'react-router-dom'

function Header(props) {
    const [searchValue, setSearchValue] = useState('')
    const [isShowAutoComplete, setIsShowAutoComplete] = useState(false)
    const [isShowForm, setIsShowForm] = useState(false)

    const navigate = useNavigate()

    const handleSearch = e => {
        setIsShowAutoComplete(Boolean(e.target.value))
        setSearchValue(e.target.value)
    }

    return (
        <div className={styles.container}>
            <div className='grid wide'>
                <div className={styles.wrap}>
                    <span className={styles.logo} onClick={() => navigate('/')}>
                        <SiEventstore className={styles.icon} />
                        𝓣𝓣𝓝𝓣
                    </span>
                    <form className={styles.searchForm}>
                        <AiOutlineSearch className={styles.searchIcon} />
                        <div className='searchGroup'>
                            <input
                                type='text'
                                placeholder='Tìm kiếm'
                                className={styles.searchInput}
                                value={searchValue}
                                onChange={handleSearch}
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
                        {/* <UserControl />
                        <Notification /> */}
                        <button
                            className={clsx(styles.button)}
                            onClick={() => navigate('create-post')}
                        >
                            <FiEdit className={styles.buttonIcon} />
                            Đăng tin
                        </button>
                    </div>
                </div>
            </div>
            <DynamicModal showModal={isShowForm}>
                <AuthForm setIsShowForm={setIsShowForm} />
            </DynamicModal>
        </div>
    )
}

export default Header
