import { createSlice } from '@reduxjs/toolkit'

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
        },
        registerFail: state => {
            state.isLoading = false
        },
    },
})

const { reducer, actions } = registerSlice

export const { registerPending, registerSuccess, registerFail } = actions

export default reducer
