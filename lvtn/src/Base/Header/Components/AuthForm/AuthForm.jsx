import styles from './authform.module.css'
import { useEffect, useState } from 'react'
import { useLocation } from 'react-router-dom'
import { FcGoogle } from 'react-icons/fc'
import { FaFacebook, FaTimes } from 'react-icons/fa'
import { useDispatch, useSelector } from 'react-redux'
import {
    selectRegisterState,
    setDefaultRegisterState,
} from '../../../../features/Auth/Register/registerSlice'
import { selectLoginStatus } from '../../../../features/Auth/Login/loginSlice'
import DynamicModal from '../../../../Common/DynamicModal/DynamicModal'
import { emitMessage } from '../../../../Common/ToastMessage/ToastMessage'

function AuthForm({ setIsShowForm }) {
    const [formMode, setFormMode] = useState('login')
    const [formData, setFormData] = useState({
        numberPhone: '',
        password: '',
    })
    const [forgotPasswordConfirmDialog, setForgotPasswordConfirmDialog] =
        useState(false)
    const registerState = useSelector(selectRegisterState)
    const dispatch = useDispatch()
    const isLogin = useSelector(selectLoginStatus)
    const { pathname } = useLocation()

    const handleFormDataChange = e => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        })
    }
    useEffect(() => {
        setFormData({ numberPhone: '', password: '' })
    }, [formMode])

    useEffect(() => {
        if (registerState) {
            setFormMode('login')
            dispatch(setDefaultRegisterState())
        }
    }, [registerState])

    useEffect(() => {
        if (isLogin) {
            setIsShowForm(false)
        }
    }, [isLogin])

    const handleSubmitForm = e => {
        e.preventDefault()
        if (formMode === 'login') {
            dispatch({ type: 'USER_LOGIN', formData })
        } else {
            dispatch({ type: 'userRegister', formData })
        }
        setFormData({
            numberPhone: '',
            password: '',
        })
    }
    return (
        <div className={styles.loginFormContainer}>
            <h1 className={styles.title}>
                {formMode === 'login' ? 'Đăng Nhập' : 'Đăng Ký'}
            </h1>
            <FaTimes
                className={styles.closeModalIcon}
                onClick={() => {
                    if (pathname !== '/create-post') {
                        setIsShowForm(false)
                    }
                }}
            />
            <form className={styles.form} onSubmit={handleSubmitForm}>
                <div className={styles.formGroup}>
                    <label className={styles.label}>Số điện thoại</label>
                    <input
                        type='tel'
                        className={styles.input}
                        placeholder='Nhập số điện thoại'
                        value={formData.numberPhone}
                        name='numberPhone'
                        onChange={handleFormDataChange}
                        autoFocus
                    />
                </div>
                <div className={styles.formGroup}>
                    <label className={styles.label}>Mật khẩu</label>
                    <input
                        type='password'
                        className={styles.input}
                        placeholder='Nhập mật khẩu'
                        value={formData.password}
                        name='password'
                        onChange={handleFormDataChange}
                    />
                </div>
                <button className={styles.loginButton}>
                    {formMode === 'login' ? 'Đăng nhập' : 'Đăng ký'}
                </button>
            </form>
            <div
                style={{
                    textAlign: 'center',
                    fontSize: 12,
                    marginTop: 10,
                    fontWeight: '500',
                    textDecoration: 'underline',
                }}
                className={styles.link}
                onClick={() => {
                    if (formData.numberPhone) {
                        setForgotPasswordConfirmDialog(true)
                    } else {
                        emitMessage('error', 'Bạn chưa nhập số điện thoại')
                    }
                }}
            >
                Bạn quên mật khẩu ?
            </div>
            <DynamicModal
                showModal={forgotPasswordConfirmDialog}
                confirmDialogConfig={{
                    title: 'Đặt lại mật khẩu',
                    content: `Bạn có chắc đặt lại mật khẩu, mật khẩu mới sẽ được gửi về số điện thoại "${formData.numberPhone}"`,
                    cancelText: 'Hủy',
                    acceptText: 'Đồng ý',
                    loadingOnDone: true,
                    onDone: value => {
                        if (!value) {
                            setForgotPasswordConfirmDialog(false)
                        } else {
                            dispatch({
                                type: 'resetPassword',
                                numberPhone: formData.numberPhone,
                            })
                        }
                    },
                }}
            ></DynamicModal>
            {/* <button
                className={clsx(styles.loginButton, styles.google)}
                style={{ display: 'block' }}
            >
                <FcGoogle className={styles.socialIcon} />
                Đăng nhập với Google
            </button>
            <button className={clsx(styles.loginButton, styles.facebook)}>
                <FaFacebook className={styles.socialIcon} />
                Đăng nhập với Facebook
            </button> */}
            <div className={styles.switchForm}>
                {formMode === 'login' ? (
                    <>
                        Chưa có tài khoản?&nbsp;
                        <span
                            className={styles.link}
                            onClick={() => setFormMode('register')}
                        >
                            Đăng ký
                        </span>
                    </>
                ) : (
                    <>
                        Đã tài khoản?&nbsp;
                        <span
                            className={styles.link}
                            onClick={() => setFormMode('login')}
                        >
                            Đăng nhập
                        </span>
                    </>
                )}
            </div>
        </div>
    )
}

export default AuthForm
