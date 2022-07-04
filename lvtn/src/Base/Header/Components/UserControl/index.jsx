import { useState } from 'react'
import { FaUserAlt } from 'react-icons/fa'
import { AiOutlineUser } from 'react-icons/ai'
import styles from './usercontrol.module.css'
import TabContainer from '../../../../Common/TabContainer'
import { useDispatch, useSelector } from 'react-redux'
import {
    logout,
    selectStatus,
} from '../../../../features/Auth/Login/loginSlice'
import { useNavigate } from 'react-router-dom'
import DynamicModal from '../../../../Common/DynamicModal/DynamicModal'
import ResetPasswordForm from '../ResetPasswordForm'

function UserControl({ username, sdt }) {
    const [isShowControlTab, setIsShowControlTab] = useState(false)
    const [isShowResetPasswordForm, setIsShowResetPasswordForm] =
        useState(false)
    const dispatch = useDispatch()
    const navigate = useNavigate()
    const isLoading = useSelector(selectStatus)

    const handleLogout = () => {
        dispatch(logout())
        navigate('/')
    }

    const handleNavigate = to => {
        navigate(to)
        setIsShowControlTab(false)
    }

    return (
        <span className={styles.wrap}>
            <FaUserAlt
                className={styles.userIcon}
                onClick={() => setIsShowControlTab(prev => !prev)}
            />
            <DynamicModal
                showModal={isShowResetPasswordForm}
                loading={isLoading}
            >
                <TabContainer
                    onClickOutside={() => setIsShowResetPasswordForm(false)}
                >
                    {isShowResetPasswordForm && (
                        <ResetPasswordForm
                            setIsShowForm={setIsShowResetPasswordForm}
                        />
                    )}
                </TabContainer>
            </DynamicModal>
            {isShowControlTab && (
                <TabContainer onClickOutside={() => setIsShowControlTab(false)}>
                    <div className={styles.controlTab}>
                        <div
                            className={styles.userInfo}
                            onClick={() => handleNavigate(`/user/${sdt}`)}
                        >
                            <AiOutlineUser className={styles.userInfoIcon} />
                            <div className={styles.name}>
                                {username}
                                <div className={styles.subTitle}>
                                    Xem trang cá nhân
                                </div>
                            </div>
                        </div>
                        <div className={styles.controlContainer}>
                            <div
                                className={styles.controlItem}
                                onClick={() => handleNavigate(`user/${sdt}`)}
                            >
                                <img
                                    src='https://static.chotot.com/storage/chotot-icons/svg/escrow-orders.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Bài đăng
                                </span>
                            </div>
                            {/* <div className={styles.controlItem}>
                                <img
                                    src='https://static.chotot.com/storage/chotot-icons/svg/escrow_buy_orders.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Đơn mua
                                </span>
                            </div> */}
                            <div
                                className={styles.controlItem}
                                onClick={() => handleNavigate(`/wish-list`)}
                            >
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
                                onClick={() => setIsShowResetPasswordForm(true)}
                            >
                                <img
                                    src='https://st.chotot.com/storage/chotot-icons/svg/settings.svg'
                                    alt='icon'
                                    className={styles.icon}
                                />
                                <span className={styles.controlLabel}>
                                    Đổi mật khẩu
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
