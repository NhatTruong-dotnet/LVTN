import loginWatcher from '../features/Auth/Login/loginSaga'
import { takeEvery, all, call } from 'redux-saga/effects'

export default function* RootSaga() {
    yield all([call(loginWatcher)])
}
