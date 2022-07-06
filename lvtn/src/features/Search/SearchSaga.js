import { takeLatest, put, call, debounce } from 'redux-saga/effects'
import {
    getPostWithCategoryId,
    getPostWithFilterParams,
    searchWithValue,
} from './SearchApi'
import {
    getPostWithCategoryIdFail,
    getPostWithCategoryIdPending,
    getPostWithCategoryIdSuccess,
    getPostWithFilterParamsFail,
    getPostWithFilterParamsPending,
    getPostWithFilterParamsSuccess,
    searchPending,
    searchSuccess,
} from './SearchSlice'

export default function* searchSaga() {
    yield takeLatest('getPostWithCategoryId', getPostWithCategoryIdSaga)
    yield takeLatest('searchWithValue', searchWithValueSaga)
    yield debounce(1000, 'getPostWithFilterParams', filterPost)
}

function* getPostWithCategoryIdSaga({ categoryId }) {
    yield put(getPostWithCategoryIdPending())

    const { status, listPost } = yield call(getPostWithCategoryId, categoryId)
    if (status === 200) {
        yield put(getPostWithCategoryIdSuccess({ listPost }))
    } else {
        yield put(getPostWithCategoryIdFail())
    }
}

function* filterPost({ searchCategory, address, params }) {
    yield put(getPostWithFilterParamsPending())
    console.log(params)
    let queryString = `${searchCategory.id}/${searchCategory.subCategoryId}`

    const { thanhPho, quanHuyen, phuongXa } = address

    queryString += `${thanhPho ? '/' + thanhPho + ';' : ''}${
        quanHuyen ? quanHuyen + ';' : ''
    }${phuongXa ? phuongXa + ';' : ''}`

    const queryStringBeforeAddParams = queryString

    for (let key in params) {
        if (
            typeof params[key] === 'object' &&
            !Array.isArray(params[key]) &&
            params[key] !== null
        ) {
            for (let subKey in params[key]) {
                queryString += `${
                    params[key][subKey] ? '/' + params[key][subKey] + ';' : ''
                }`
            }
        } else {
            queryString += `${params[key] ? '/' + params[key] + ';' : ''}`
        }
    }
    if (queryStringBeforeAddParams === queryString) {
        queryString += '/null'
    }
    console.log(queryString)
    const { status, listPost } = yield call(
        getPostWithFilterParams,
        queryString
    )
    if (status === 200) {
        yield put(getPostWithFilterParamsSuccess({ listPost }))
    } else {
        yield put(getPostWithFilterParamsFail())
    }
}

function* searchWithValueSaga({ searchValue }) {
    yield put(searchPending())

    const { status, listPost } = yield call(searchWithValue, searchValue)
    if (status === 200) {
        yield put(searchSuccess({ listPost }))
    }
}
