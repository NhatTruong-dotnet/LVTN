import { put, takeLeading, takeLatest, call, select } from 'redux-saga/effects'
import {
    createNewPost,
    getPostDetailWithId,
    getPostWithSubCategoryId,
} from './PostApi'
import {
    createPostFail,
    createPostPending,
    createPostSuccess,
    getPostDetailFail,
    getPostDetailPending,
    getPostDetailSuccess,
    getPostPending,
    getPostSuccess,
} from './PostSlice'
import { selectToken, selectUsername } from '../Auth/Login/loginSlice'

export default function* postSaga() {
    yield takeLeading('createPost', createPost)
    yield takeLeading('getPost', getPost)
    yield takeLatest('getPostDetail', getPostDetail)
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

function* getPostDetail({ idPost }) {
    console.log(idPost)
    yield put(getPostDetailPending())
    const { status, postDetail, errorMessage } = yield call(
        getPostDetailWithId,
        idPost
    )
    if (status === 200) {
        yield put(getPostDetailSuccess({ postDetail }))
    } else {
        yield put(getPostDetailFail({ errorMessage }))
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
    25: 'doDienTuDienThoai',
    26: 'doDienTuMayTinhBang',
    27: 'doDienTuLaptop',
    28: 'doDienTuMayTinhDeBan',
    29: 'doDienTuMayAnh',
    30: 'doDienTuTivi',
    31: 'doDienTuThietBiDeoThongMinh',
    32: 'doDienTuPhuKien',
    33: 'doDienTuLinhKien',
    4: 'viecLam',
    34: 'thuCungGaMeoThuCungKhac',
    35: 'thuCungCho',
    36: 'thuCungChim',
    37: 'thuCungGaMeoThuCungKhac',
    38: 'thuCungGaMeoThuCungKhac',
    6: 'doAnThucPham',
    40: 'baiDangTuLanh',
    41: 'baiDangMayLanh',
    42: 'baiDangMayGiat',
    43: 'baiDangDoGiaDungBanGhe',
    44: 'baiDangDoGiaDungTuKe',
    45: 'baiDangDoGiaDungGiuong',
    46: 'baiDangDoGiaDungBep',
    47: 'baiDangDoGiaDungDenCayCanhNoiThat',
    48: 'baiDangDoGiaDungQuat',
    49: 'baiDangDoGiaDungDenCayCanhNoiThat',
    50: 'baiDangDoGiaDungDenCayCanhNoiThat',
    51: 'baiDangDoGiaDungThietBiVeSinh',
    52: 'baiDangDoGiaDungDenCayCanhNoiThat',
    9: 'baiDangMeVaBe',
    53: 'baiDangThoiTrang',
    54: 'baiDangThoiTrang',
    55: 'baiDangThoiTrang',
    56: 'baiDangThoiTrang',
    57: 'baiDangThoiTrang',
    58: 'baiDangThoiTrang',
    59: 'baiDangGiaiTriNhacCu',
    60: 'baiDangGiaiTri',
    61: 'baiDangGiaiTri',
    62: 'baiDangGiaiTriDoSuuTam',
    63: 'baiDangGiaiTri',
    64: 'baiDangGiaiTri',
    65: 'baiDangDoDungVanPhong',
    66: 'baiDangDoDungVanPhong',
}

function mappingFormData(formData, numberPhone) {
    const { subCategoryId, categoryId } = formData

    return {
        ...formData,
        paramUrl: params[subCategoryId || categoryId],
        anTin: true,
        trangThai: false,
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
