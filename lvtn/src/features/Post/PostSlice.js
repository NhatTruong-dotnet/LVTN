import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
}

const postSlice = createSlice({
    name: 'post',
    initialState,
    reducers: {
        createPostPending(state) {
            state.isLoading = true
        },
        createPostSuccess(state) {
            state.isLoading = false
            emitMessage('success', 'Thêm bài đăng mới thành công')
        },
        createPostFail(state, action) {
            state.isLoading = false
            emitMessage('error', action.payload.errorMessage)
        },
    },
})

const { reducer, actions } = postSlice

export const { createPostPending, createPostSuccess, createPostFail } = actions

export default reducer
