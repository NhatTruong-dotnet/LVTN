import loginWatcher from '../features/Auth/Login/loginSaga'
import { all, call } from 'redux-saga/effects'
import registerWatcher from '../features/Auth/Register/registerSaga'

export default function* RootSaga() {
    yield all([call(loginWatcher), call(registerWatcher)])
}
