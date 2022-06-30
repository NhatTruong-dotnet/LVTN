import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
    isLoadingUserPost: false,
    userInfo: {
        soDienThoai: '',
        ten: '',
        diaChi: '',
        danhGiaHeThong: '',
        cmnd: '',
        createdDate: '',
        anhDaiDienSource: '',
    },
    userPost: [],
}

const userSlice = createSlice({
    name: 'user',
    initialState,
    reducers: {
        getUserProfilePending: state => {
            state.isLoading = true
        },
        getUserProfileSuccess: (state, action) => {
            state.isLoading = false
            state.userInfo = action.payload.userProfile
            state.userInfo.cmnd =
                state.userInfo.cmnd === null ? '' : state.userInfo.cmnd
        },
        getUserProfileFail: (state, action) => {
            state.isLoading = false
        },
        // --------------------------------------
        getUserPostPending: (state, action) => {
            state.isLoadingUserPost = true
        },
        getUserPostSuccess: (state, action) => {
            state.isLoadingUserPost = false
            state.userPost = action.payload.userPost
        },
        // --------------------------------------
        getUserPostWithStatusPending: (state, action) => {
            state.isLoadingUserPost = true
        },
        getUserPostWithStatusSuccess: (state, action) => {
            state.isLoadingUserPost = false
            state.userPost = action.payload.userPost
        },
        getUserPostWithStatusFail: (state, action) => {
            state.isLoadingUserPost = false
            state.userPost = []
        },
        // --------------------------------------
        updateProfileUserPending: (state, action) => {
            state.isLoading = true
        },
        upDateProfileUserSuccess: (state, action) => {
            state.isLoading = false
            emitMessage('success', action.payload.message)
        },
        upDateProfileUserFail: (state, action) => {
            state.isLoading = false
            emitMessage('error', action.payload.message)
        },
    },
})

const { reducer, actions } = userSlice

export const {
    getUserProfilePending,
    getUserProfileSuccess,
    getUserProfileFail,
    // -------------------
    getUserPostPending,
    getUserPostSuccess,
    // -------------------
    getUserPostWithStatusPending,
    getUserPostWithStatusSuccess,
    getUserPostWithStatusFail,
    // -------------------
    updateProfileUserPending,
    upDateProfileUserSuccess,
    upDateProfileUserFail,
} = actions

export const selectUserInfo = state => state.user.userInfo
export const selectUserPost = state => state.user.userPost
export const selectPendingState = state => state.user.isLoading
export const selectPendingStateUserPost = state => state.user.isLoadingUserPost

export default reducer
