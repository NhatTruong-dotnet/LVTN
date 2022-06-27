const listCategoryFilterParams = [
    // Chung cư
    {
        categoryId: 1,
        subCategoryId: 13,
        filterParams: [
            {
                key: 'ban',
                label: 'Mong muốn',
                type: 'array',
                data: [
                    { value: 'Bán', text: 'Bán' },
                    { value: 'Cho thuê', text: 'Cho thuê' },
                ],
            },
            {
                key: 'gia',
                label: 'Giá',
                type: 'number',
                min: 0,
                max: 30000000000,
            },
            {
                key: 'dienTich',
                label: 'Diện tích',
                type: 'number',
                min: 0,
                max: 1000,
                unit: 'm²',
            },
            {
                key: 'loaiHinh',
                label: 'Loại hình chung cư',
                type: 'multiChoice',
                data: [
                    { value: 'Chung cư', text: 'Chung cư' },
                    { value: 'Duplex', text: 'Duplex' },
                    { value: 'PentHouse', text: 'PentHouse' },
                    {
                        value: 'Căn hộ dịch vụ, mini',
                        text: 'Căn hộ dịch vụ, mini',
                    },
                    { value: 'Tập thể, cư xá', text: 'Tập thể, cư xá' },
                    { value: 'Officetel', text: 'Officetel' },
                ],
            },
            {
                key: 'soPhongNgu',
                label: 'Số phòng ngủ',
                type: 'array',
                data: [
                    { value: '1', text: '1' },
                    { value: '2', text: '2' },
                    { value: '3', text: '3' },
                    { value: '4', text: '4' },
                    { value: '5', text: '5' },
                    { value: '6', text: '6' },
                    { value: '7', text: '7' },
                    { value: '8', text: '8' },
                    { value: '9', text: '9' },
                    { value: '10', text: '10' },
                    { value: 'trên 10', text: 'trên 10' },
                ],
                unit: 'phòng ngủ',
            },
            {
                key: 'soToilet',
                label: 'Số phòng vệ sinh',
                type: 'array',
                data: [
                    { value: '1', text: '1' },
                    { value: '2', text: '2' },
                    { value: '3', text: '3' },
                    { value: '4', text: '4' },
                    { value: '5', text: '5' },
                    { value: '6', text: '6' },
                    { value: '7', text: '7' },
                    { value: '8', text: '8' },
                    { value: '9', text: '9' },
                    { value: '10', text: '10' },
                    { value: 'trên 10', text: 'trên 10' },
                ],
                unit: 'toilet',
            },
            {
                key: 'huongBanCong',
                label: 'Hướng ban công',
                type: 'array',
                data: [
                    { value: 'Đông', text: 'Đông' },
                    { value: 'Tây', text: 'Tây' },
                    { value: 'Nam', text: 'Nam' },
                    { value: 'Bắc', text: 'Bắc' },
                    { value: 'Đông Bắc', text: 'Đông Bắc' },
                    { value: 'Đông Nam', text: 'Đông Nam' },
                    { value: 'Tây Bắc', text: 'Tây Bắc' },
                    { value: 'Tây Nam', text: 'Tây Nam' },
                ],
            },
            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    { value: 'Đông', text: 'Đông' },
                    { value: 'Tây', text: 'Tây' },
                    { value: 'Nam', text: 'Nam' },
                    { value: 'Bắc', text: 'Bắc' },
                    { value: 'Đông Bắc', text: 'Đông Bắc' },
                    { value: 'Đông Nam', text: 'Đông Nam' },
                    { value: 'Tây Bắc', text: 'Tây Bắc' },
                    { value: 'Tây Nam', text: 'Tây Nam' },
                ],
            },
            {
                key: 'tinhTrangNoiThat',
                label: 'Tình trạng nội thất',
                type: 'array',
                data: [
                    { value: 'Bàn giao thô', text: 'Bàn giao thô' },
                    { value: 'Nội thất cơ bản', text: 'Nội thất cơ bản' },
                    { value: 'Nội thất đầy dủ', text: 'Nội thất đầy dủ' },
                    {
                        value: 'Nội thất sang trọng',
                        text: 'Nội thất sang trọng',
                    },
                ],
            },
            {
                key: 'banGiao',
                label: 'Bàn giao',
                type: 'array',
                data: [
                    { value: 'Đã bàn giao', text: 'Đã bàn giao' },
                    { value: 'Chưa bàn giao', text: 'Chưa bàn giao' },
                ],
            },
            {
                key: 'giayToPhapLy',
                label: 'Giấy tờ pháp lý',
                type: 'array',
                data: [
                    { value: 'Đã có sổ', text: 'Đã có sổ' },
                    { value: 'Chưa có sổ', text: 'Chưa có sổ' },
                    { value: 'Giấy tờ khác', text: 'Giấy tờ khác' },
                ],
            },
        ],
    },
    // Nhà
    {
        categoryId: 1,
        subCategoryId: 14,
        filterParams: [
            {
                key: 'ban',
                label: 'Mong muốn',
                type: 'array',
                data: [
                    { value: true, text: 'Bán' },
                    { value: false, text: 'Cho thuê' },
                ],
            },
            {
                key: 'gia',
                label: 'Giá',
                type: 'number',
                min: 0,
                max: 30000000000,
            },
            {
                key: 'dienTich',
                label: 'Diện tích',
                type: 'number',
                min: 0,
                max: 1000,
                unit: 'm²',
            },
            {
                key: 'loaiHinh',
                label: 'Loại hình nhà ở',
                type: 'array',
                data: [
                    {
                        value: 'Nhà mặt phố, mặt tiền',
                        text: 'Nhà mặt phố, mặt tiền',
                    },
                    { value: 'Nhà ngỏ, hẻm', text: 'Nhà ngỏ, hẻm' },
                    { value: 'Nhà biệt thự', text: 'Nhà biệt thự' },
                    { value: 'Nhà phố liền kề', text: 'Nhà phố liền kề' },
                ],
            },
            {
                key: 'soPhongNgu',
                label: 'Số phòng ngủ',
                type: 'array',
                data: [
                    { value: '1', text: '1' },
                    { value: '2', text: '2' },
                    { value: '3', text: '3' },
                    { value: '4', text: '4' },
                    { value: '5', text: '5' },
                    { value: '6', text: '6' },
                    { value: '7', text: '7' },
                    { value: '8', text: '8' },
                    { value: '9', text: '9' },
                    { value: '10', text: '10' },
                    { value: 'trên 10', text: 'trên 10' },
                ],
                unit: 'phòng ngủ',
            },
            {
                key: 'soToilet',
                label: 'Số phòng vệ sinh',
                type: 'array',
                data: [
                    { value: '1', text: '1' },
                    { value: '2', text: '2' },
                    { value: '3', text: '3' },
                    { value: '4', text: '4' },
                    { value: '5', text: '5' },
                    { value: '6', text: '6' },
                    { value: '7', text: '7' },
                    { value: '8', text: '8' },
                    { value: '9', text: '9' },
                    { value: '10', text: '10' },
                    { value: 'trên 10', text: 'trên 10' },
                ],
                unit: 'toilet',
            },

            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    { value: 'Đông', text: 'Đông' },
                    { value: 'Tây', text: 'Tây' },
                    { value: 'Nam', text: 'Nam' },
                    { value: 'Bắc', text: 'Bắc' },
                    { value: 'Đông Bắc', text: 'Đông Bắc' },
                    { value: 'Đông Nam', text: 'Đông Nam' },
                    { value: 'Tây Bắc', text: 'Tây Bắc' },
                    { value: 'Tây Nam', text: 'Tây Nam' },
                ],
            },
            {
                key: 'tinhTrangNoiThat',
                label: 'Tình trạng nội thất',
                type: 'array',
                data: [
                    { value: 'Bàn giao thô', text: 'Bàn giao thô' },
                    { value: 'Nội thất cơ bản', text: 'Nội thất cơ bản' },
                    { value: 'Nội thất đầy dủ', text: 'Nội thất đầy dủ' },
                    {
                        value: 'Nội thất sang trọng',
                        text: 'Nội thất sang trọng',
                    },
                ],
            },
            {
                key: 'banGiao',
                label: 'Bàn giao',
                type: 'array',
                data: [
                    { value: 'Đã bàn giao', text: 'Đã bàn giao' },
                    { value: 'Chưa bàn giao', text: 'Chưa bàn giao' },
                ],
            },
            {
                key: 'giayToPhapLy',
                label: 'Giấy tờ pháp lý',
                type: 'array',
                data: [
                    { value: 'Đã có sổ', text: 'Đã có sổ' },
                    { value: 'Chưa có sổ', text: 'Chưa có sổ' },
                    { value: 'Giấy tờ khác', text: 'Giấy tờ khác' },
                ],
            },
        ],
    },
    // Đất
    {
        categoryId: 1,
        subCategoryId: 15,
        filterParams: [
            {
                key: 'ban',
                label: 'Mong muốn',
                type: 'array',
                data: [
                    { value: true, text: 'Bán' },
                    { value: false, text: 'Cho thuê' },
                ],
            },
            {
                key: 'gia',
                label: 'Giá',
                type: 'number',
                min: 0,
                max: 30000000000,
            },
            {
                key: 'dienTich',
                label: 'Diện tích',
                type: 'number',
                min: 0,
                max: 1000,
                unit: 'm²',
            },
            {
                key: 'loaiHinh',
                label: 'Loại hình đất',
                type: 'array',
                data: [
                    {
                        value: 'Đất thổ cư',
                        text: 'Đất thổ cư',
                    },
                    { value: 'Đất nền dự án', text: 'Đất nền dự án' },
                    { value: 'Đất công nghiệp', text: 'Đất công nghiệp' },
                    { value: 'Đất nông nghiệp', text: 'Đất nông nghiệp' },
                ],
            },
            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    { value: 'Đông', text: 'Đông' },
                    { value: 'Tây', text: 'Tây' },
                    { value: 'Nam', text: 'Nam' },
                    { value: 'Bắc', text: 'Bắc' },
                    { value: 'Đông Bắc', text: 'Đông Bắc' },
                    { value: 'Đông Nam', text: 'Đông Nam' },
                    { value: 'Tây Bắc', text: 'Tây Bắc' },
                    { value: 'Tây Nam', text: 'Tây Nam' },
                ],
            },
            {
                key: 'dacDiemDat',
                label: 'Đặc điểm đất',
                type: 'array',
                data: [
                    { value: 'Hẻm xe hơi', text: 'Hẻm xe hơi' },
                    { value: 'Mặt tiền', text: 'Mặt tiền' },
                    { value: 'Nở hậu', text: 'Nở hậu' },
                ],
            },
            {
                key: 'banGiao',
                label: 'Bàn giao',
                type: 'array',
                data: [
                    { value: 'Đã bàn giao', text: 'Đã bàn giao' },
                    { value: 'Chưa bàn giao', text: 'Chưa bàn giao' },
                ],
            },
            {
                key: 'giayToPhapLy',
                label: 'Giấy tờ pháp lý',
                type: 'array',
                data: [
                    { value: 'Đã có sổ', text: 'Đã có sổ' },
                    { value: 'Chưa có sổ', text: 'Chưa có sổ' },
                    { value: 'Giấy tờ khác', text: 'Giấy tờ khác' },
                ],
            },
        ],
    },
    // Văn phòng
    {
        categoryId: 1,
        subCategoryId: 16,
        filterParams: [
            {
                key: 'ban',
                label: 'Mong muốn',
                type: 'array',
                data: [
                    { value: true, text: 'Bán' },
                    { value: false, text: 'Cho thuê' },
                ],
            },
            {
                key: 'gia',
                label: 'Giá',
                type: 'number',
                min: 0,
                max: 30000000000,
            },
            {
                key: 'dienTich',
                label: 'Diện tích',
                type: 'number',
                min: 0,
                max: 1000,
                unit: 'm²',
            },
            {
                key: 'loaiHinh',
                label: 'Loại hình văn phòng',
                type: 'array',
                data: [
                    {
                        value: 'Mặt bằng kinh doanh',
                        text: 'Mặt bằng kinh doanh',
                    },
                    { value: 'Văn phòng', text: 'Văn phòng' },
                    { value: 'Shophouse', text: 'Shophouse' },
                    { value: 'Officetel', text: 'Officetel' },
                ],
            },
            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    { value: 'Đông', text: 'Đông' },
                    { value: 'Tây', text: 'Tây' },
                    { value: 'Nam', text: 'Nam' },
                    { value: 'Bắc', text: 'Bắc' },
                    { value: 'Đông Bắc', text: 'Đông Bắc' },
                    { value: 'Đông Nam', text: 'Đông Nam' },
                    { value: 'Tây Bắc', text: 'Tây Bắc' },
                    { value: 'Tây Nam', text: 'Tây Nam' },
                ],
            },
            {
                key: 'tinhTrangNoiThat',
                label: 'Tình trạng nội thất',
                type: 'array',
                data: [
                    { value: 'Bàn giao thô', text: 'Bàn giao thô' },
                    { value: 'Nội thất cơ bản', text: 'Nội thất cơ bản' },
                    { value: 'Nội thất đầy dủ', text: 'Nội thất đầy dủ' },
                    {
                        value: 'Nội thất sang trọng',
                        text: 'Nội thất sang trọng',
                    },
                ],
            },
            {
                key: 'banGiao',
                label: 'Bàn giao',
                type: 'array',
                data: [
                    { value: 'Đã bàn giao', text: 'Đã bàn giao' },
                    { value: 'Chưa bàn giao', text: 'Chưa bàn giao' },
                ],
            },
            {
                key: 'giayToPhapLy',
                label: 'Giấy tờ pháp lý',
                type: 'array',
                data: [
                    { value: 'Đã có sổ', text: 'Đã có sổ' },
                    { value: 'Chưa có sổ', text: 'Chưa có sổ' },
                    { value: 'Giấy tờ khác', text: 'Giấy tờ khác' },
                ],
            },
        ],
    },
]

export const getFilterParams = (categoryId, subCategoryId) => {
    const findResult = listCategoryFilterParams.find(
        item =>
            item.categoryId === categoryId &&
            item.subCategoryId === subCategoryId
    )

    return findResult ? findResult.filterParams : []
}
