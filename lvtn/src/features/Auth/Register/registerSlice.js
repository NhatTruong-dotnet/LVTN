import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
    isRegisterSuccess: false,
}

const registerSlice = createSlice({
    name: 'register',
    initialState,
    reducers: {
        registerPending: state => {
            state.isLoading = true
        },
        registerSuccess: state => {
            state.isLoading = false
            state.isRegisterSuccess = true
            emitMessage('success', 'Đăng ký thành công')
        },
        registerFail: (state, action) => {
            state.isLoading = false
            emitMessage('error', action.payload.errorMessage)
        },
        setDefaultRegisterState: state => {
            state.isLoading = false
            state.isRegisterSuccess = null
        },
    },
})

const { reducer, actions } = registerSlice

export const {
    registerPending,
    registerSuccess,
    registerFail,
    setDefaultRegisterState,
} = actions

export const selectRegisterState = state => state.register.isRegisterSuccess

export default reducer
