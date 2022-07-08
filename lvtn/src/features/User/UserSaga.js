import { takeLatest, call, put, select, takeLeading } from 'redux-saga/effects'
import { selectToken } from '../Auth/Login/loginSlice'
import {
    getUserPost,
    getUserPostWithStatus,
    getUserProfile,
    updateProfileUser,
    setActivePost,
} from './UserApi'
import {
    getUserProfileFail,
    getUserProfileSuccess,
    getUserPostSuccess,
    upDateProfileUserSuccess,
    upDateProfileUserFail,
    updateProfileUserPending,
    getUserProfilePending,
    getUserPostPending,
    getUserPostWithStatusPending,
    getUserPostWithStatusSuccess,
    getUserPostWithStatusFail,
    setActivePostFail,
    setActivePostPending,
    setActivePostSuccess,
} from './UserSlice'

export default function* userSaga() {
    yield takeLatest('getProfile', getProfileSaga)
    yield takeLatest('getUserPost', getUserPostSaga)
    yield takeLatest('updateProfileUser', updateProfileSaga)
    yield takeLatest('getUserPostWithStatus', getUserPostWithStatusSaga)
    yield takeLeading('setActivePost', setActivePostSaga)
}

function* setActivePostSaga({ active, idPost, statusTab }) {
    const token = yield select(selectToken)
    if (!token) {
        yield put(
            setActivePostFail({
                errorMessage:
                    'Phiên đăng nhập hết hạn, vui lòng đăng nhập thử lại',
            })
        )
        return
    }
    yield put(setActivePostPending())
    const { status, errorMessage } = yield call(
        setActivePost,
        token,
        idPost,
        active
    )
    if (status === 200) {
        yield put(
            setActivePostSuccess({
                message: `${active ? 'Ẩn' : 'Hiện'} tin thành công`,
            })
        )
        yield put({ type: 'getUserPostWithStatus', postStatus: statusTab })
    } else {
        yield put(
            setActivePostFail({
                message:
                    errorMessage || 'Đã có lỗi xảy ra, vui lòng thử lại sau',
            })
        )
    }
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

function* getUserPostWithStatusSaga({ postStatus }) {
    const token = yield select(selectToken)
    yield put(getUserPostWithStatusPending())
    const { userPost, status, errorMessage } = yield call(
        getUserPostWithStatus,
        token,
        postStatus
    )
    if (status === 200) {
        yield put(getUserPostWithStatusSuccess({ userPost }))
    } else if (status === 401) {
        yield put(
            getUserPostWithStatusSuccess({
                errorMessage:
                    'Phiên đăng nhập hết hạn, vui lòng đăng nhập và thử lại sau',
            })
        )
    } else {
        yield put(getUserPostWithStatusFail({ errorMessage }))
    }
}
