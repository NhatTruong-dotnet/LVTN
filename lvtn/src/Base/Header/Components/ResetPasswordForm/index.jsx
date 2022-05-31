import styles from './index.module.css'
import { FaTimes } from 'react-icons/fa'
import { useState } from 'react'
import { useDispatch } from 'react-redux'

function ResetPasswordForm({ setIsShowForm }) {
    const [formData, setFormData] = useState({
        password: '',
        rePassword: '',
    })
    const dispatch = useDispatch()

    const handleFormDataChange = e => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        })
    }

    const handleChangePassword = e => {
        e.preventDefault()
        dispatch({ type: 'changePassword', password: formData.password })
    }

    return (
        <div className={styles.loginFormContainer}>
            <h1 className={styles.title}>Đổi mật khẩu</h1>
            <FaTimes
                className={styles.closeModalIcon}
                onClick={() => setIsShowForm(false)}
            />
            <form className={styles.form} onSubmit={handleChangePassword}>
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
                <div className={styles.formGroup}>
                    <label className={styles.label}>Nhập lại mật khẩu</label>
                    <input
                        type='password'
                        className={styles.input}
                        placeholder='Nhập lại mật khẩu'
                        value={formData.rePassword}
                        name='rePassword'
                        onChange={handleFormDataChange}
                    />
                </div>
                <button className={styles.loginButton}>Xác nhận</button>
            </form>
        </div>
    )
}

export default ResetPasswordForm
