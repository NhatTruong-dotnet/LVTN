import { createSlice } from '@reduxjs/toolkit'

const initialState = {
    isLoading: false,
    userInfo: {
        soDienThoai: '',
        ten: '',
        diaChi: '',
        danhGiaHeThong: null,
        createdDate: null,
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
        },
        getUserProfileFail: (state, action) => {
            state.isLoading = false
        },
        // --------------------------------------
        getUserPostSuccess: (state, action) => {
            state.userPost = action.payload.userPost
        },
    },
})

const { reducer, actions } = userSlice

export const {
    getUserProfilePending,
    getUserProfileSuccess,
    getUserProfileFail,
    getUserPostSuccess,
} = actions

export const selectUserInfo = state => state.user.userInfo
export const selectUserPost = state => state.user.userPost

export default reducer
