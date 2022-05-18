import { put, takeLeading, call } from 'redux-saga/effects'
import { createNewPost } from './PostApi'
import {
    createPostFail,
    createPostPending,
    createPostSuccess,
} from './PostSlice'

export default function* createPostWatcher() {
    yield takeLeading('createPost', createPost)
}

function* createPost({ formData, numberPhone, token }) {
    yield put(createPostPending())
    const requestFormData = mappingFormData(formData, numberPhone)
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
    }
}
