import { put, takeLeading, call, select } from 'redux-saga/effects'
import { createNewPost, getPostWithSubCategoryId } from './PostApi'
import {
    createPostFail,
    createPostPending,
    createPostSuccess,
    getPostPending,
    getPostSuccess,
} from './PostSlice'
import { selectToken, selectUsername } from '../Auth/Login/loginSlice'

export default function* postSaga() {
    yield takeLeading('createPost', createPost)
    yield takeLeading('getPost', getPost)
}

function* getPost({ lastSubCategories }) {
    yield put(getPostPending())
    const { status, postData } = yield call(
        getPostWithSubCategoryId,
        lastSubCategories
    )
    if (status === 200) {
        yield put(getPostSuccess({ postData }))
    } else {
        // yield put(getPostFail({errorMessage}))
    }
}

function* createPost({ formData }) {
    yield put(createPostPending())

    const token = yield select(selectToken)
    const username = yield select(selectUsername)

    const requestFormData = mappingFormData(formData, username)

    const { status, errorMessage } = yield call(
        createNewPost,
        requestFormData,
        token
    )
    if (status === 200) {
        yield put(createPostSuccess())
    } else if (status === 401) {
        yield put(
            createPostFail({
                errorMessage:
                    'Phiên làm việc hết hạn, vui lòng đăng nhập và thử lại',
            })
        )
    } else {
        yield put(createPostFail({ errorMessage }))
    }
}

const params = {
    13: 'batDongSanCC',
    14: 'batDongSanNhaO',
    15: 'batDongSanDat',
    16: 'batDongSanVanPhong',
    17: 'batDongSanPhongTro',
    18: 'xeCoOto',
    19: 'xeCoXeMay',
    20: 'xeCoXeTai',
    21: 'xeCoXeDien',
    22: 'xeCoXeDap',
    23: 'xeCoPhuongTienKhac',
    24: 'xeCoPhuTungXe',
}

function mappingFormData(formData, numberPhone) {
    const { subCategoryId, categoryId } = formData

    return {
        ...formData,
        paramUrl: params[subCategoryId || categoryId],
        anTin: true,
        trangThai: false,
        mienPhi: false,
        idBaiDangChiTiet: 0,
        tablesDetail: 'string',

        idDanhMucCha: formData.categoryId,
        sdtNguoiBan: numberPhone,
        sdtNguoiMua: '',
        tieuDe: formData.title,
        mota: formData.description,
        idDanhMucCon: subCategoryId,
        hinhAnh_BaiDangs: formData.medias,
        diaChiCuThe: formData.soNha + formData.tenDuong,
    }
}
