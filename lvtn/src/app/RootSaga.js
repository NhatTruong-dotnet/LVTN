import loginWatcher from '../features/Auth/Login/loginSaga'
import { all, call } from 'redux-saga/effects'
import registerWatcher from '../features/Auth/Register/registerSaga'
import postSaga from '../features/Post/PostSaga'
import userSaga from '../features/User/UserSaga'

export default function* RootSaga() {
    yield all([
        call(loginWatcher),
        call(registerWatcher),
        call(postSaga),
        call(userSaga),
    ])
}
