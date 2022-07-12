import { call, put, takeLeading, select } from 'redux-saga/effects'
import { changePassword, Login } from './loginApi'
import {
    loginPending,
    loginSuccess,
    loginFail,
    changePasswordPending,
    selectToken,
    changePasswordFail,
    changePasswordSuccess,
    selectNumberPhone,
} from './loginSlice'

export default function* loginWatcher() {
    yield takeLeading('USER_LOGIN', loginWorker)
    yield takeLeading('changePassword', changePasswordSaga)
}

function* loginWorker({ formData }) {
    yield put(loginPending())
    const { status, token, errorMessage } = yield call(Login, formData)
    if (status === 200) {
        yield put(loginSuccess({ token }))
    } else if (status === 400) {
        yield put(loginFail({ status, errorMessage }))
    } else {
        yield put(loginFail({ errorMessage }))
    }
}

function* changePasswordSaga({ password }) {
    const token = yield select(selectToken)
    const soDienThoai = yield select(selectNumberPhone)
    if (!token || !soDienThoai) {
        yield put(
            changePasswordFail({
                errorMessage:
                    'Phiên đăng nhập hết hạn, vui lòng đăng nhập và thử lại',
            })
        )
    } else {
        yield put(changePasswordPending())
        const { status, errorMessage } = yield call(changePassword, {
            token,
            soDienThoai,
            password,
        })
        if (status === 200) {
            yield put(changePasswordSuccess())
        } else if (status === 401) {
            yield put(
                changePasswordFail({
                    errorMessage:
                        errorMessage ||
                        'Phiên đăng nhập hết hạn, vui lòng đăng nhập và thử lại',
                })
            )
        } else {
            yield put(changePasswordFail({ errorMessage }))
        }
    }
}
