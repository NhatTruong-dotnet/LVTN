import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
    listPost: [],
    selectedPostDetail: {},
    wishList: [],
    relatedPost: [],
    locationData: [],
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
        // -------------------------------------
        getPostPending(state) {
            state.isLoading = true
        },
        getPostSuccess(state, action) {
            state.isLoading = false
            state.listPost = action.payload.postData
        },
        getPostFail(state) {
            state.isLoading = false
        },
        clearListPost(state) {
            state.listPost = []
        },
        // -------------------------------------
        getPostDetailPending(state) {
            state.isLoading = true
        },
        getPostDetailSuccess(state, action) {
            state.isLoading = false
            state.selectedPostDetail = action.payload.postDetail
        },
        getPostDetailFail(state, action) {
            state.isLoading = false
            emitMessage(
                'error',
                action.payload.errorMessage ||
                    'Có lỗi xảy ra, vui lòng chờ trong giây lát và thử lại sau'
            )
        },
        // --------------------------------------
        getWishList(state) {
            const wishList = JSON.parse(localStorage.getItem('wishList'))
            if (Array.isArray(wishList)) {
                state.wishList = wishList
            }
        },
        addWishList(state, action) {
            state.wishList.push(action.payload)
            localStorage.setItem('wishList', JSON.stringify(state.wishList))
        },
        removeItemWishList(state, action) {
            const removeItemId = action.payload
            state.wishList = state.wishList.filter(
                ({ idPost }) => idPost !== removeItemId
            )
            localStorage.setItem('wishList', JSON.stringify(state.wishList))
        },
        removeWishList(state) {
            state.wishList = []
            localStorage.setItem('wishList', JSON.stringify([]))
        },
        // --------------------------------------------------------
        getRelatedPostSuccess(state, action) {
            const relatedPost = action.payload.relatedPost
            if (Array.isArray(relatedPost)) {
                state.relatedPost = relatedPost.splice(0, 4)
            }
        },
        // --------------------------------------------------------
        setLocation(state, action) {
            const locationData = action.payload.locationData
            const locationArray = []
            for (let key in locationData) {
                locationArray.push(locationData[key])
            }
            state.locationData = locationArray
        },
    },
})

const { reducer, actions } = postSlice

export const {
    createPostPending,
    createPostSuccess,
    createPostFail,
    // ------------
    getPostPending,
    getPostSuccess,
    getPostFail,
    clearListPost,
    // ------------
    getPostDetailPending,
    getPostDetailSuccess,
    getPostDetailFail,
    // ------------
    getWishList,
    addWishList,
    removeItemWishList,
    removeWishList,
    // ------------
    getRelatedPostSuccess,
    // ------------
    setLocation,
} = actions

export const selectListPost = state => state.post.listPost
export const selectPostDetail = state => state.post.selectedPostDetail
export const selectWishList = state => state.post.wishList
export const selectRelatedPost = state => state.post.relatedPost
export const selectPendingStatusPost = state => state.post.isLoading
export const selectLocation = state => state.post.locationData

export default reducer
