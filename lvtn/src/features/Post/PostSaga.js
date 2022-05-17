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

function mappingFormData(formData, numberPhone) {
    const { subCategoryId } = formData
    switch (subCategoryId) {
        case 13:
            return {
                paramUrl: 'batDongSanCC',
                idDanhMucCha: formData.categoryId,
                sdtNguoiBan: numberPhone,
                sdtNguoiMua: '',
                anTin: true,
                canBan: Boolean(formData.isSell),
                trangThai: false,
                thanhPho: formData.address.city,
                quanHuyen: formData.address.district,
                phuongXa: formData.address.ward,
                diaChiCuThe: formData.address.number + formData.address.street,
                tieuDe: formData.title,

                idDanhMucCon: subCategoryId,
                mota: formData.description,
                mienPhi: false,
                gia: formData.price,
                caNhan: Boolean(formData.isOwner),

                tenDuAn: formData.name,
                dienTich: formData.acreage,
                maCan: formData.apartmentId,
                block: formData.block,
                tangSo: formData.floor,
                chuaBanGiao: Boolean(formData.isHandOver),
                loaiHinh: formData.apartmentType,
                soPhongNgu: formData.amountBedroom,
                idBaiDangChiTiet: 0,
                tablesDetail: 'string',
                hinhAnh_BaiDangs: formData.medias,
                ccHuongCuaChinh: formData.mainDoor,
                ccBanCong: formData.balcony,
                ccGiayToPhapLy: formData.exhibit,
                ccTinhTrangNoiThat: formData.furniture,
                soTienCoc: formData.deposit || 0,
            }
        case 14:
            return {
                paramUrl: 'batDongSanNhaO',
                idDanhMucCha: formData.categoryId,
                sdtNguoiBan: numberPhone,
                sdtNguoiMua: '',
                anTin: true,
                canBan: Boolean(formData.isSell),
                trangThai: false,
                thanhPho: formData.address.city,
                quanHuyen: formData.address.district,
                phuongXa: formData.address.ward,
                diaChiCuThe: formData.address.number + formData.address.street,
                tieuDe: formData.title,
                idDanhMucCon: subCategoryId,
                mota: formData.description,
                mienPhi: false,
                gia: formData.price,
                caNhan: Boolean(formData.isOwner),
                tenDuAn: formData.name,
                dienTich: formData.acreage,
                chuaBanGiao: Boolean(formData.isHandOver),
                nhaOLoaiHinh: formData.houseType,
                nhaOSoPhongNgu: formData.amountBedroom,
                nhaOSoPhongVeSinh: formData.amountToilet,
                nhaOTongSoTang: formData.floor,
                nhaOHemXeHoi: Boolean(formData.isAlley),
                nhaONoHau: Boolean(formData.hasBackyard),
                nhaOChieuNgang: formData.horizontal,
                nhaOChieuDai: formData.vertical,
                idBaiDangChiTiet: 0,
                tablesDetail: 'string',
                hinhAnh_BaiDangs: formData.medias,
                nhaOHuongCuaChinh: formData.mainDoor,
                nhaOBanCong: formData.balcony,
                nhaOGiayToPhapLy: formData.exhibit,
                nhaOTinhTrangNoiThat: formData.furniture,
                soTienCoc: formData.deposit || 0,
            }

        default:
            break
    }
}
