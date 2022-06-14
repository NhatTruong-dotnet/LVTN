import { createSlice } from '@reduxjs/toolkit'

const initialState = {
    listNotify: [],
    errorMessage: '',
}

const notifySlice = createSlice({
    name: 'notify',
    initialState,
    reducers: {
        getAllNotifySuccess: (state, action) => {
            state.listNotify = action.payload.listNotify
        },
        getAllNotifyFail: (state, action) => {
            state.errorMessage = action.payload.errorMessage
        },
        addNewNotify: (state, action) => {
            state.listNotify.unshift(action.payload.newNotify)
        },
    },
})

const { reducer, actions } = notifySlice

export const { getAllNotifySuccess, getAllNotifyFail, addNewNotify } = actions

export const selectListNotify = state => state.notify.listNotify

export default reducer
