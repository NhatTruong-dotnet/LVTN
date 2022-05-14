import styles from './authform.module.css'
import { useEffect, useState } from 'react'
import clsx from 'clsx'

import { FcGoogle } from 'react-icons/fc'
import { FaFacebook, FaTimes } from 'react-icons/fa'
import { useDispatch, useSelector } from 'react-redux'
import {
    selectRegisterState,
    setDefaultRegisterState,
} from '../../../../features/Auth/Register/registerSlice'

function AuthForm({ setIsShowForm }) {
    const [formMode, setFormMode] = useState('login')
    const [formData, setFormData] = useState({
        numberPhone: '',
        password: '',
    })
    const registerState = useSelector(selectRegisterState)
    const dispatch = useDispatch()

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
                {formMode === 'login' ? 'Welcome back' : 'Create Account'}
            </h1>
            <FaTimes
                className={styles.closeModalIcon}
                onClick={() => setIsShowForm(false)}
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
            <button
                className={clsx(styles.loginButton, styles.google)}
                style={{ display: 'block' }}
            >
                <FcGoogle className={styles.socialIcon} />
                Đăng nhập với Google
            </button>
            <button className={clsx(styles.loginButton, styles.facebook)}>
                <FaFacebook className={styles.socialIcon} />
                Đăng nhập với Facebook
            </button>
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
