import { createSlice } from '@reduxjs/toolkit'

const initialState = {
    isLoading: false,
    listPost: [],
}

const searchSlice = createSlice({
    name: 'search',
    initialState,
    reducers: {
        searchPending: state => {
            state.isLoading = true
        },
        searchSuccess: (state, action) => {
            state.isLoading = false
            state.listPost = action.payload.listPost
        },
        // ------------------------------
        getPostWithCategoryIdPending: state => {
            state.isLoading = true
        },
        getPostWithCategoryIdSuccess: (state, action) => {
            state.isLoading = false
            state.listPost = action.payload.listPost
        },
        // -------------------------------
        getPostWithFilterParamsPending: state => {
            state.isLoading = true
        },
        getPostWithFilterParamsSuccess: (state, action) => {
            state.isLoading = false
            state.listPost = action.payload.listPost
        },
    },
})

const { reducer, actions } = searchSlice

export const {
    searchPending,
    searchSuccess,
    // ------------------------------
    getPostWithCategoryIdPending,
    getPostWithCategoryIdSuccess,
    // -----------------------------
    getPostWithFilterParamsPending,
    getPostWithFilterParamsSuccess,
} = actions

export const selectSearchListPost = state => state.search.listPost
export const selectSearchPendingState = state => state.search.isLoading

export default reducer
