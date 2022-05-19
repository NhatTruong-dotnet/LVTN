import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
    listPost: [],
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

        getPostPending(state) {
            state.isLoading = true
        },
        getPostSuccess(state, action) {
            state.isLoading = false
            state.listPost = action.payload.listPost
        },
        getPostFail(state) {
            state.isLoading = false
        },
    },
})

const { reducer, actions } = postSlice

export const {
    createPostPending,
    createPostSuccess,
    createPostFail,
    getPostPending,
    getPostSuccess,
    getPostFail,
} = actions

export const selectListPost = state => state.post.listPost

export default reducer
