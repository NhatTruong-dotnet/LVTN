import {
    call,
    put,
    takeEvery,
    select,
    actionChannel,
    take,
} from 'redux-saga/effects'
import { selectNumberPhone, selectToken } from '../Auth/Login/loginSlice'
import { addNewMessage, getAllConversation, getAllMessage } from './ChatApi'
import {
    addMessage,
    addNewMessageApiFail,
    addNewMessageApiSuccess,
    getAllConversationFail,
    getAllConversationPending,
    getAllConversationSuccess,
    getAllMessageFail,
    getAllMessageSuccess,
    selectCurrentConversationId,
    selectReceiveUserSdt,
    setCurrentConversationId,
} from './ChatSlice'

export default function* chatSaga() {
    yield takeEvery('getAllConversation', getAllConversationSaga)
    yield takeEvery('getAllMessage', getAllMessageSaga)
    yield takeEvery('addNewMessage', addNewMessageSaga)
    yield call(receiveMessageSaga)
}

function* getAllConversationSaga() {
    const token = yield select(selectToken)
    const sdt = yield select(selectNumberPhone)
    const receiveUserSdt = yield select(selectReceiveUserSdt)
    const currentConversationId = yield select(selectCurrentConversationId)
    if (!token || !sdt) {
        return
    }

    yield put(getAllConversationPending())

    const { listConversation, status, errorMessage } = yield call(
        getAllConversation,
        token,
        sdt
    )

    if (status === 200) {
        yield put(getAllConversationSuccess({ listConversation }))
        const selectedConversation = listConversation.find(
            ({ sdtNguoiMua }) => sdtNguoiMua === receiveUserSdt
        )
        if (selectedConversation) {
            yield put(
                setCurrentConversationId(selectedConversation.conversationId)
            )
        } else if (currentConversationId === 0) {
            yield put(
                setCurrentConversationId(listConversation[0].conversationId)
            )
        }
    } else if (status === 401) {
        yield put(
            getAllConversationFail({
                errorMessage:
                    'Phiên đăng nhập hết hạn, vui lòng đăng nhập và thử lại sau',
            })
        )
    } else {
        yield put(getAllConversationFail({ errorMessage }))
    }
}

function* getAllMessageSaga({ id }) {
    const { listMessage, status, errorMessage } = yield call(getAllMessage, id)
    if (status === 200) {
        yield put(getAllMessageSuccess({ listMessage }))
        localStorage.setItem('lastConversation', id)
    } else if (status === 401) {
        yield put(
            getAllMessageFail({
                errorMessage:
                    'Phiên làm việc hết hạn, vui lòng đăng nhập và thử lại',
            })
        )
    } else {
        yield put(getAllMessageFail({ errorMessage }))
    }
}

function* receiveMessageSaga() {
    const requestChan = yield actionChannel('ReceiveMessage')
    while (true) {
        // 2- take from the channel
        const { message } = yield take(requestChan)
        // 3- Note that we're using a blocking call
        yield call(handleReceiveMessage, message)
    }
}

function* handleReceiveMessage(message) {
    yield put(
        addMessage({
            newMessage: {
                messagesBy: message.MessageBy,
                messageText: message.MessageText,
                messageImageSource: message.MessageImageSource,
            },
        })
    )
}

function* addNewMessageSaga({ messageText, listFileDataMedia }) {
    const sdt = yield select(selectNumberPhone)
    const token = yield select(selectToken)
    const currentChatUserSdt = yield select(selectReceiveUserSdt)
    const currentConversationId = yield select(selectCurrentConversationId)
    if (!token) {
        return
    }

    yield put(
        addMessage({
            newMessage: {
                messagesBy: sdt,
                messageTo: currentChatUserSdt,
                messageText,
                messageImageSource: '',
            },
        })
    )

    const { status, id } = yield call(
        addNewMessage,
        token,
        sdt,
        currentChatUserSdt,
        messageText,
        listFileDataMedia
    )
    if (status === 200) {
        yield put(addNewMessageApiSuccess())
        if (!currentConversationId) {
            yield put({ type: 'getAllMessage', id })
        }
        window.invokeMethod('SendMessage', sdt)
    } else if (status === 401) {
        yield put(
            addNewMessageApiFail({
                errorMessage:
                    'Phiên đăng nhập hết hạn, vui lòng đăng nhập và thử lại sau',
            })
        )
    }
}
