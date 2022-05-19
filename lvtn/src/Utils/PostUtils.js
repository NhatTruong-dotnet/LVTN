const array = [
    {
        categoryId: 1,
        subCategories: [
            // Apartment
            {
                subCategoryId: 13,
                canBan: null,
                banGiao: null,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
                maCan: '',
                block: '',
                tangSo: '',
                loaiHinh: '',
                soPhongNgu: '',
                soToilet: '',
                ccBanCong: '',
                ccHuongCuaChinh: '',
                ccGiayToPhapLy: '',
                ccTinhTrangNoiThat: '',
                dienTich: '',
                gia: '',
                soTienCoc: '',
                caNhan: null,
            },
            // House
            {
                subCategoryId: 14,
                canBan: null,
                banGiao: null,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },

                soTang: '',
                loaiHinh: '',
                soPhongNgu: '',
                soToilet: '',
                nhaOHuongCuaChinh: '',
                nhaOGiayToPhapLy: '',
                nhaOTinhTrangNoiThat: '',
                nhaOhemXeHoi: false,
                nhaOnoHau: false,
                dienTich: '',
                dienTichSuDung: '',
                nhaOchieuNgang: '',
                nhaOchieuDai: '',
                gia: '',
                soTienCoc: '',
                caNhan: null,
            },
            // Land
            {
                subCategoryId: 15,
                canBan: null,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },

                datMatTien: false,
                loaiHinh: '',
                datHuongDat: '',
                datGiayToPhapLy: '',
                datHemXeHoi: false,
                datNoHau: false,
                dienTich: '',
                datChieuNgang: '',
                datChieuDai: '',
                gia: '',
                soTienCoc: '',
                caNhan: null,
            },
            // Office
            {
                subCategoryId: 16,
                canBan: null,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },

                vanPhongTangSo: '',
                vanPhongLoaiHinhVanPhong: '',
                vanPhongHuongCuaChinh: '',
                vanPhongGiayToPhapLy: '',
                vanPhongTinhTrangNoiThat: '',
                dienTich: '',
                gia: '',
                soTienCoc: '',
                caNhan: null,
            },
            // Motel
            {
                subCategoryId: 17,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
                phongTroTinhTrangNoiThat: '',
                dienTich: '',
                gia: '',
                soTienCoc: '',
                caNhan: null,
            },
        ],
    },
    {
        categoryId: 2,
        subCategories: [
            {
                subCategoryId: 18,
                hangXe: '',
                dongXe: '',
                nam: '',
                xuatxu: '',
                bienSoXe: '',
                soKmDaDi: '',
                daSuDung: true,
                mauSac: '',
                otoHopSo: '',
                otoNhieuLieu: '',
                otoKieuDang: '',
                otoSocho: '',
                gia: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 20,
                hangXe: '',
                nam: '',
                xuatxu: '',
                bienSoXe: '',
                soKmDaDi: '',
                daSuDung: true,
                gia: '',
                mauSac: '',
                xeTaiTrongTai: '',
                xeTaiNhieuLieu: '',
                xeTaiXuatXu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 19,
                hangXe: '',
                dongXe: '',
                nam: '',
                xuatxu: '',
                bienSoXe: '',
                soKmDaDi: '',
                daSuDung: true,
                xeMayDungtich: '',
                xeMayLoaiXe: '',
                gia: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 21,
                hangXe: '',
                nam: '',
                xuatxu: '',
                xeDienDaSuDung: true,
                gia: '',
                mauSac: '',
                xeDienLoaiXe: '',
                xeDienDongCo: '',
                xeDienBaoHanh: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 22,
                hangXe: '',
                nam: '',
                xuatxu: '',
                gia: '',
                mauSac: '',
                xeDapDaSuDung: true,
                xeDapLoaiXe: '',
                xeDapKichThuocKhung: '',
                xeDapChatLuongKhung: '',
                xeDapBaoHang: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 23,
                hangXe: '',
                nam: '',
                xuatxu: '',
                gia: '',
                mauSac: '',
                bienSoXe: '',
                soKmDaDi: '',
                phuongTienDaSuDung: '',
                phuongTienKhacLoaiXe: '',
                phuongTienKhacDongXe: '',
                phuongTienKhacSoCho: '',
                phuongTienKhacSuDung: true,
                phuongTienKhacNhienLieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 24,
                gia: '',
                phuTungXeLoaiPhuTung: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
        ],
    },
]

export const generateDefaultValueFormData = (id, subCategoryId) => {
    let defaultFormData = {
        title: '',
        description: '',
        mediaIds: [],
    }
    array.forEach(({ categoryId, subCategories }) => {
        if (id === categoryId) {
            defaultFormData.categoryId = id
            subCategories.forEach(subCategory => {
                if (subCategory.subCategoryId === subCategoryId) {
                    defaultFormData = {
                        ...defaultFormData,
                        ...subCategory,
                    }
                }
            })
        }
    })

    return defaultFormData
}

export function convertFile(file, callback) {
    const reader = new FileReader() //this for convert to Base64
    reader.readAsDataURL(file) //start conversion...

    reader.onload = function (e) {
        //.. once finished..
        const rawLog = reader.result.split(',')[1] //extract only thee file data part
        const dataSend = {
            dataReq: { data: rawLog, name: file.name, type: file.type },
            fname: 'uploadFilesToGoogleDrive',
        } //preapre info to send to API
        callback({ type: file.type, fileData: dataSend })
    }
}

export const uploadImage = async files => {
    const fileIdArray = await Promise.all(
        files.map(async ({ type, fileData }) => {
            const res = await fetch(
                'https://script.google.com/macros/s/AKfycbwXhX4N82ic3vhrVOK493pjOfR9-pISPf7jsSmpiBcf_IHuQCc/exec',
                { method: 'POST', body: JSON.stringify(fileData) }
            )
            const { id } = await res.json()
            return { type, id }
        })
    )
    return fileIdArray
}
