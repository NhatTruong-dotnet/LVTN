import { takeLatest, call, put, select } from 'redux-saga/effects'
import { selectToken } from '../Auth/Login/loginSlice'
import { getUserPost, getUserProfile, updateProfileUser } from './UserApi'
import {
    getUserProfileFail,
    getUserProfileSuccess,
    getUserPostSuccess,
    upDateProfileUserSuccess,
    upDateProfileUserFail,
    updateProfileUserPending,
    getUserProfilePending,
    getUserPostPending,
} from './UserSlice'

export default function* userSaga() {
    yield takeLatest('getProfile', getProfileSaga)
    yield takeLatest('getUserPost', getUserPostSaga)
    yield takeLatest('updateProfileUser', updateProfileSaga)
}

function* updateProfileSaga({ payload }) {
    yield put(updateProfileUserPending())
    const token = yield select(selectToken)
    const { message, status } = yield call(
        updateProfileUser,
        payload.sdt,
        payload.formData,
        token
    )
    if (status === 200) {
        yield put(upDateProfileUserSuccess({ message }))
    } else if (status === 401) {
        yield put(
            upDateProfileUserFail({
                message:
                    'Phiên đăng nhập đã hết hạn, vui lòng đăng nhập và thử lại',
            })
        )
    } else {
        yield put(
            upDateProfileUserFail({
                message:
                    'Có lỗi xảy ra, vui lòng đợi trong giây lát sau đó tải lại trang và thử lại sau',
            })
        )
    }
}

function* getProfileSaga({ sdt }) {
    yield put(getUserProfilePending())
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
    yield put(getUserPostPending())
    const { userPost, status, errorMessage } = yield call(getUserPost, sdt)
    if (status === 200) {
        yield put(getUserPostSuccess({ userPost }))
    } else {
        yield put(getUserProfileFail({ errorMessage }))
    }
}
