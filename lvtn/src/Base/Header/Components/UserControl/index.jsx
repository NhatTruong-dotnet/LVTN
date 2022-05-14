import { useState } from 'react'
import { FaUserAlt } from 'react-icons/fa'
import { AiOutlineUser } from 'react-icons/ai'
import styles from './usercontrol.module.css'
import TabContainer from '../../../../Common/TabContainer'
import { useDispatch } from 'react-redux'
import { logout } from '../../../../features/Auth/Login/loginSlice'

function UserControl({ username }) {
    const [isShowControlTab, setIsShowControlTab] = useState(false)
    const dispatch = useDispatch()
    const handleLogout = () => {
        dispatch(logout())
    }

    return (
        <span className={styles.wrap}>
            <FaUserAlt
                className={styles.userIcon}
                onClick={() => setIsShowControlTab(true)}
            />
            {isShowControlTab && (
                <TabContainer onClickOutside={() => setIsShowControlTab(false)}>
                    <div className={styles.controlTab}>
                        <div className={styles.userInfo}>
                            <AiOutlineUser className={styles.userInfoIcon} />
                            <div className={styles.name}>
                                {username}
                                <div className={styles.subTitle}>
                                    Xem trang cá nhân
                                </div>
                            </div>
                        </div>
                        <div className={styles.controlContainer}>
                            <div className={styles.controlItem}>
                                <img
                                    src='https://static.chotot.com/storage/chotot-icons/svg/escrow-orders.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Đơn bán
                                </span>
                            </div>
                            <div className={styles.controlItem}>
                                <img
                                    src='https://static.chotot.com/storage/chotot-icons/svg/escrow_buy_orders.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Đơn mua
                                </span>
                            </div>
                            <div className={styles.controlItem}>
                                <img
                                    src='https://static.chotot.com/storage/chotot-icons/svg/menu-saved-ad.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Yêu thích
                                </span>
                            </div>
                            <div
                                className={styles.controlItem}
                                onClick={handleLogout}
                            >
                                <img
                                    src='https://st.chotot.com/storage/chotot-icons/svg/sign-out.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Đăng xuất
                                </span>
                            </div>
                        </div>
                    </div>
                </TabContainer>
            )}
        </span>
    )
}

export default UserControl
