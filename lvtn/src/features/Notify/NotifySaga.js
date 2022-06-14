import { takeEvery, call, select, put } from 'redux-saga/effects'
import { getAllNotify } from './NotifyApi'
import { selectNumberPhone } from '../Auth/Login/loginSlice'
import { getAllNotifyFail, getAllNotifySuccess } from './NotifySlice'

export default function* notifySaga() {
    yield takeEvery('getAllNotify', getAllNotifySaga)
}

function* getAllNotifySaga() {
    const sdt = yield select(selectNumberPhone)

    const { listNotify, status, errorMessage } = yield call(getAllNotify, sdt)
    console.log(listNotify)
    if (status === 200) {
        yield put(getAllNotifySuccess({ listNotify }))
    } else {
        yield put(getAllNotifyFail({ errorMessage }))
    }
}
