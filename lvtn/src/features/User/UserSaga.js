import { takeLatest, call, put } from 'redux-saga/effects'
import { getUserPost, getUserProfile } from './UserApi'
import {
    getUserProfileFail,
    getUserProfileSuccess,
    getUserPostSuccess,
} from './UserSlice'

export default function* userSaga() {
    yield takeLatest('getProfile', getProfileSaga)
    yield takeLatest('getUserPost', getUserPostSaga)
}
function* getProfileSaga({ sdt }) {
    const { userProfile, status, errorMessage } = yield call(
        getUserProfile,
        sdt
    )
    if (status === 200) {
        yield put(getUserProfileSuccess({ userProfile }))
    } else {
        yield put(getUserProfileFail({ errorMessage }))
    }
}
function* getUserPostSaga({ sdt }) {
    const { userPost, status, errorMessage } = yield call(getUserPost, sdt)
    if (status === 200) {
        yield put(getUserPostSuccess({ userPost }))
    } else {
        yield put(getUserProfileFail({ errorMessage }))
    }
}
