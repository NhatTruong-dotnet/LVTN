import { createSlice } from '@reduxjs/toolkit'
import jwt_decode from 'jwt-decode'
import { emitMessage } from '../../../Common/ToastMessage/ToastMessage'

const initialState = {
    token: '',
    isLogin: false,
    username: '',
    isLoading: false,
    role: null,
}

export const loginSlice = createSlice({
    name: 'login',
    initialState,
    reducers: {
        loginWithToken: state => {
            const token = localStorage.getItem('token')
            if (token) {
                const expireTime = localStorage.getItem('expire')
                const { name, role } = jwt_decode(token)
                const currentTime = new Date().getTime()

                if (expireTime > currentTime) {
                    state.token = token
                    state.isLogin = true
                    state.username = name
                    state.role = role
                    emitMessage('success', `Welcome back ${name || ''}`)
                } else {
                    localStorage.removeItem('token')
                }
            }
        },
        loginPending: state => {
            state.isLoading = true
        },
        loginSuccess: (state, action) => {
            const { exp, name, role } = jwt_decode(action.payload.token)
            state.isLoading = false
            state.isLogin = true
            state.username = name
            state.role = role
            state.token = action.payload.token
            emitMessage('success', `Welcome ${name || ''}`)
            localStorage.setItem('token', action.payload.token)
            localStorage.setItem('expire', new Date().getTime() + exp)
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
    },
})

const { reducer, actions } = loginSlice

export const { loginPending, loginSuccess, loginFail, logout, loginWithToken } =
    actions

export const selectStatus = state => state.login.isLoading
export const selectUsername = state => state.login.username
export const selectLoginStatus = state => state.login.isLogin
export const selectToken = state => state.login.token

export default reducer
