import { createSlice } from '@reduxjs/toolkit'
import jwt_decode from 'jwt-decode'
import { emitMessage } from '../../../Common/ToastMessage/ToastMessage'

const initialState = {
    token: '',
    isLogin: false,
    username: '',
    sdt: '',
    isLoading: false,
    role: null,
}

function getUserInfoInToken(token) {
    const decoded = jwt_decode(token)
    const { exp } = decoded

    const username =
        decoded['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name']

    const sdt =
        decoded[
            'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname'
        ]

    const role =
        decoded['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role']
    return { username, sdt, role, exp }
}

export const loginSlice = createSlice({
    name: 'login',
    initialState,
    reducers: {
        loginWithToken: state => {
            const token = localStorage.getItem('token')
            if (token) {
                const { username, sdt, role, exp } = getUserInfoInToken(token)

                if (exp > Date.now() / 1000) {
                    state.token = token
                    state.isLogin = true
                    state.username = username
                    state.sdt = sdt
                    state.role = role
                } else {
                    localStorage.removeItem('token')
                }
            }
        },
        // ----------------------------------------------------
        loginPending: state => {
            state.isLoading = true
        },
        loginSuccess: (state, action) => {
            const { username, sdt, role, exp } = getUserInfoInToken(
                action.payload.token
            )

            state.isLoading = false
            state.isLogin = true
            state.username = username
            state.sdt = sdt
            state.role = role
            state.token = action.payload.token
            emitMessage('success', `Welcome ${username || ''}`)
            localStorage.setItem('token', action.payload.token)
            console.log(exp)
        },
        loginFail: (state, action) => {
            state.isLoading = false
            emitMessage('error', action.payload.errorMessage)
        },
        logout: state => {
            state.isLogin = false
            state.username = ''
            state.role = null
            state.token = ''
            localStorage.removeItem('expire')
            localStorage.removeItem('token')
        },
        // --------------------------------------------------
        changePasswordPending: state => {
            state.isLoading = true
        },
        changePasswordSuccess: state => {
            state.isLoading = false
            emitMessage('success', 'Cập nhật password thành công')
        },
        changePasswordFail: (state, action) => {
            state.isLoading = false
            emitMessage(
                'error',
                action.payload.errorMessage ||
                    'Đã có lỗi xảy ra, vui lòng chờ trong giây lát và thử lại sau'
            )
        },
    },
})

const { reducer, actions } = loginSlice

export const {
    loginPending,
    loginSuccess,
    loginFail,
    logout,
    // ---------------
    loginWithToken,
    // ---------------
    changePasswordPending,
    changePasswordSuccess,
    changePasswordFail,
} = actions

export const selectStatus = state => state.login.isLoading
export const selectUsername = state => state.login.username
export const selectNumberPhone = state => state.login.sdt
export const selectLoginStatus = state => state.login.isLogin
export const selectToken = state => state.login.token

export default reducer
