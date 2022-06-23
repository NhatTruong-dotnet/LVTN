const array = [
    {
        categoryId: 1,
        subCategories: [
            // Apartment
            {
                subCategoryId: 13,
                canBan: null,
                chuaBanGiao: null,
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
                chuaBanGiao: null,
                tenDuAn: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },

                soTang: '',
                nhaOLoaiHinh: '',
                nhaOSoPhongNgu: '',
                nhaOHuongCuaChinh: '',
                nhaOSoPhongVeSinh: '',
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
                datLoaiHinhDat: '',
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
                phongTroSoTienCoc: '',
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
                otoDongXe: '',
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
                xeMayDongXe: '',
                nam: '',
                mauSac: '',
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
    {
        categoryId: 3,
        subCategories: [
            {
                subCategoryId: 25,
                gia: '',
                dienThoaiHang: '',
                dienThoaiDongMay: '',
                dienThoaiMauSac: '',
                dienThoaiDungLuong: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                phienBan: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // Tablet
            {
                subCategoryId: 26,
                gia: '',
                mayTinhBangHang: '',
                mayTinhBangDongMay: '',
                mayTinhBangDungLuong: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                mayTinhBangQuocTe: false,
                mayTinhBang4g: '',
                mayTinhBangKichCoManHinh: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // Laptop
            {
                subCategoryId: 27,
                gia: '',
                laptopHang: '',
                laptopDongMay: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                laptopBoViXuly: '',
                laptopRam: '',
                laptopOcung: '',
                laptopHdd: '',
                laptopCardManHinh: '',
                laptopKichCoManHinh: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // Desktop
            {
                subCategoryId: 28,
                gia: '',
                tinhTrang: '',
                baoHanh: '',
                mayTinhDeBanMienPhi: false,
                mayTinhDeBanBoViXuly: '',
                mayTinhDeBanRam: '',
                mayTinhDeBanOcung: '',
                mayTinhDeBanHdd: '',
                mayTinhDeBanCardManHinh: '',
                mayTinhDeBanKichCoManHinh: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // camera
            {
                subCategoryId: 29,
                gia: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                mayAnhThietBi: '',
                thietBiDongMay: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // Smart device
            {
                subCategoryId: 31,
                gia: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                thietBiDeoThongMinhThietBi: '',
                thietBiDeoThongMinhHang: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // phu kien
            {
                subCategoryId: 32,
                gia: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                phuKienLoaiPhuKien: '',
                phuKienThietBi: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // linh kiện
            {
                subCategoryId: 33,
                gia: '',
                tinhTrang: '',
                baoHanh: '',
                mienPhi: false,
                linhKienLoaiPhuKien: '',
                linhKienThietBi: '',
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
    // Việc làm
    {
        categoryId: 4,
        tinhTrang: '',
        caNhan: false,
        tenHoKinhDoanh: '',
        soLuongTuyenDung: '',
        nganhNghe: '',
        loaiCongViec: '',
        hinhThucTraLuong: '',
        luongToiThieu: '',
        luongToiDa: '',
        doTuoiToiThieu: '',
        doTuoiToiDa: '',
        nam: false,
        hocVanToiThieu: '',
        kinhNghiem: '',
        chungChi: '',
        quyenLoi: '',
        address: {
            thanhPho: '',
            quanHuyen: '',
            phuongXa: '',
            tenDuong: '',
            soNha: '',
        },
    },
    {
        categoryId: 5,
        subCategories: [
            {
                subCategoryId: 34,
                mienPhi: false,
                gia: '',
                giongThuCung: '',
                doTuoi: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 35,
                mienPhi: false,
                gia: '',
                giongThuCung: '',
                doTuoi: '',
                choKichCo: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 36,
                mienPhi: false,
                gia: '',
                giongThuCung: '',
                doTuoi: '',
                chimGioiTinh: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 37,
                mienPhi: false,
                gia: '',
                giongThuCung: '',
                doTuoi: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 38,
                mienPhi: false,
                gia: '',
                giongThuCung: '',
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
    {
        categoryId: 6,
        mienPhi: false,
        gia: '',
        loaiThucPham: '',
        address: {
            thanhPho: '',
            quanHuyen: '',
            phuongXa: '',
            tenDuong: '',
            soNha: '',
        },
    },
    {
        categoryId: 7,
        subCategories: [
            {
                subCategoryId: 40,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                tuLanhTheTich: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 41,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                mayLanhCongSuat: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 42,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                mayGiatCuaMayGiat: '',
                mayGiatKhoiLuongGiat: '',
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
    {
        categoryId: 8,
        subCategories: [
            // bàn ghế
            {
                subCategoryId: 43,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                banGheChatLieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // tủ kệ
            {
                subCategoryId: 44,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                tuKeChatLieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // giường
            {
                subCategoryId: 45,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                giuongChatLieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // bếp
            {
                subCategoryId: 46,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                bepThuongHieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // dụng cụ bếp
            {
                subCategoryId: 47,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // quạt
            {
                subCategoryId: 48,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                quatThuongHieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // Đèn
            {
                subCategoryId: 49,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // cây
            {
                subCategoryId: 50,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // vệ sinh
            {
                subCategoryId: 51,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                thietBiVeSinhThuongHieu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 52,
                mienPhi: false,
                gia: '',
                hang: '',
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
    {
        categoryId: 9,
        mienPhi: false,
        gia: '',
        hang: '',
        daSuDung: false,
        loaiSanPham: '',
        address: {
            thanhPho: '',
            quanHuyen: '',
            phuongXa: '',
            tenDuong: '',
            soNha: '',
        },
    },
    {
        categoryId: 10,
        subCategories: [
            // quần áo
            {
                subCategoryId: 53,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // đồng hồ
            {
                subCategoryId: 54,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // giày dép
            {
                subCategoryId: 55,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // túi xách
            {
                subCategoryId: 56,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // nước hoa
            {
                subCategoryId: 57,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // phụ kiện
            {
                subCategoryId: 58,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                loaiSanPham: '',
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
    {
        categoryId: 11,
        subCategories: [
            // nhạc cụ
            {
                subCategoryId: 59,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                nhacCuLoaiNhacCu: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // sách
            {
                subCategoryId: 60,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // đồ thể thao
            {
                subCategoryId: 61,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // đồ sưu tầm
            {
                subCategoryId: 62,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                doSuuTamLoaiSanPham: '',
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // game
            {
                subCategoryId: 63,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            // khác
            {
                subCategoryId: 64,
                mienPhi: false,
                gia: '',
                hang: '',
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
    {
        categoryId: 12,
        subCategories: [
            {
                subCategoryId: 65,
                mienPhi: false,
                gia: '',
                hang: '',
                daSuDung: false,
                address: {
                    thanhPho: '',
                    quanHuyen: '',
                    phuongXa: '',
                    tenDuong: '',
                    soNha: '',
                },
            },
            {
                subCategoryId: 66,
                mienPhi: false,
                gia: '',
                hang: '',
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
        medias: [],
    }
    console.log(id)
    array.forEach(({ categoryId, subCategories }) => {
        if (id === categoryId) {
            defaultFormData.categoryId = id
            if (!subCategoryId) {
                const form = array.find(item => item.categoryId === categoryId)
                defaultFormData = {
                    ...defaultFormData,
                    ...form,
                    title: '',
                    description: '',
                    medias: [],
                    address: {
                        thanhPho: '',
                        quanHuyen: '',
                        phuongXa: '',
                        tenDuong: '',
                        soNha: '',
                    },
                }
            } else {
                subCategories.forEach(subCategory => {
                    if (subCategory.subCategoryId === subCategoryId) {
                        defaultFormData = {
                            ...defaultFormData,
                            ...subCategory,
                        }
                    }
                })
            }
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
