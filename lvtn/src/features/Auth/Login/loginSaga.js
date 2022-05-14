import { take, fork, call, put } from 'redux-saga/effects'
import { Login } from './loginApi'
import { loginPending, loginSuccess, loginFail } from './loginSlice'

export default function* loginWatcher() {
    while (true) {
        const action = yield take('USER_LOGIN')
        yield fork(loginWorker, action.formData)
        // const registerAction = yield take('USER_LOGOUT')
        // yield fork()
    }
}

function* loginWorker(formData) {
    yield put(loginPending())
    const { status, token, errorMessage } = yield call(Login, formData)
    if (status === 200) {
        yield put(loginSuccess({ token }))
    } else {
        yield put(loginFail({ errorMessage }))
    }
}
