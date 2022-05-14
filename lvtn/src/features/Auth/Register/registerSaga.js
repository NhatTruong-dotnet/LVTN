import { takeEvery, put, call } from 'redux-saga/effects'
import { registerPending, registerSuccess, registerFail } from './registerSlice'
import Register from './registerApi'

export default function* registerWatcher() {
    yield takeEvery('userRegister', register)
}

function* register({ formData }) {
    yield put(registerPending())
    const { status, errorMessage } = yield call(Register, formData)
    if (status === 200) {
        yield put(registerSuccess())
    } else {
        yield put(registerFail({ errorMessage }))
    }
}
