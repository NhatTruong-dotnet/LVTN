import { takeLatest, put, call } from 'redux-saga/effects'
import { getPostWithCategoryId, searchWithValue } from './SearchApi'
import {
    getPostWithCategoryIdPending,
    getPostWithCategoryIdSuccess,
    searchPending,
    searchSuccess,
} from './SearchSlice'

export default function* searchSaga() {
    yield takeLatest('getPostWithCategoryId', getPostWithCategoryIdSaga)
    yield takeLatest('searchWithValue', searchWithValueSaga)
}

function* getPostWithCategoryIdSaga({ categoryId }) {
    yield put(getPostWithCategoryIdPending())

    const { status, listPost } = yield call(getPostWithCategoryId, categoryId)
    if (status === 200) {
        yield put(getPostWithCategoryIdSuccess({ listPost }))
    }
}

function* searchWithValueSaga({ searchValue }) {
    yield put(searchPending())

    const { status, listPost } = yield call(searchWithValue, searchValue)
    if (status === 200) {
        yield put(searchSuccess({ listPost }))
    }
}
