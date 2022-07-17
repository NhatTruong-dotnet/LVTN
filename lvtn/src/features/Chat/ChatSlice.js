import { createSlice } from '@reduxjs/toolkit'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'

const initialState = {
    isLoading: false,
    listConversation: [],
    currentConversation: {
        conversationId: '',
        receiveUserInfo: {
            ten: '',
            soDienThoai: '',
            anhDaiDienSource: '',
        },
        listMessage: [],
    },
}

const chatSlice = createSlice({
    name: 'chat',
    initialState,
    reducers: {
        getAllConversationPending: state => {
            state.isLoading = true
        },
        getAllConversationSuccess: (state, action) => {
            state.isLoading = false
            state.listConversation = action.payload.listConversation
        },
        getAllConversationFail: (state, action) => {
            state.isLoading = false
            emitMessage('error', action.payload.errorMessage)
        },

        setReceiveUserInfo: (state, action) => {
            const { ten, soDienThoai, anhDaiDienSource } =
                action.payload.userInfo
            state.currentConversation.receiveUserInfo = {
                ten,
                soDienThoai,
                anhDaiDienSource,
            }
        },
        setCurrentConversation: (state, action) => {
            state.currentConversation = action.payload.conversation
        },
        // ---------------------------
        getAllMessageSuccess: (state, action) => {
            state.currentConversation.listMessage = action.payload.listMessage
        },
        getAllMessageFail: (state, action) => {
            console.log(action.payload)
        },
        setCurrentConversationId: (state, action) => {
            state.currentConversation.id = action.payload
        },
        // -----------------------------------------
        addMessage(state, action) {
            state.currentConversation.listMessage.push(
                action.payload.newMessage
            )
        },
        addNewMessageApiSuccess: (state, action) => {},
        addNewMessageApiFail: (state, action) => {
            state.currentConversation.listMessage.pop()
            emitMessage('error', action.payload.errorMessage)
        },
        // -------------------------------------------
        setDefaultConversation: state => {
            state.currentConversation = {
                conversationId: '',
                receiveUserInfo: {
                    ten: '',
                    soDienThoai: '',
                    anhDaiDienSource: '',
                },
                listMessage: [],
            }
        },
    },
})

const { reducer, actions } = chatSlice

export const {
    getAllConversationPending,
    getAllConversationSuccess,
    getAllConversationFail,
    // -----------------------
    setCurrentConversationId,
    setReceiveUserInfo,
    setCurrentConversation,
    // -----------------------
    getAllMessagePending,
    getAllMessageSuccess,
    getAllMessageFail,
    // ------------------------
    addMessage,
    addNewMessageApiSuccess,
    addNewMessageApiFail,
    // ------------------------
    setDefaultConversation,
} = actions

export const selectListConversation = state => state.chat.listConversation
export const selectCurrentConversation = state => state.chat.currentConversation
export const selectCurrentConversationId = state =>
    state.chat.currentConversation.id
export const selectListMessage = state =>
    state.chat.currentConversation.listMessage
export const selectReceiveUserInfo = state =>
    state.chat.currentConversation.receiveUserInfo
export const selectReceiveUserSdt = state =>
    state.chat.currentConversation.receiveUserInfo.soDienThoai

export default reducer
