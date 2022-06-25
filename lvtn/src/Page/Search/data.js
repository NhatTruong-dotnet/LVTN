const listCategoryFilterParams = [
    {
        categoryId: 1,
        subCategoryId: 13,
        filterParams: [
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
                type: 'array',
                data: [
                    'Chung cư',
                    'Duplex',
                    'PentHouse',
                    'Căn hộ dịch vụ, mini',
                    'Tập thể, cư xá',
                    'Officetel',
                ],
            },
            {
                key: 'soPhongNgu',
                label: 'Số phòng ngủ',
                type: 'array',
                data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'Trên 10'],
                unit: 'phòng ngủ',
            },
            {
                key: 'soToilet',
                label: 'Số phòng vệ sinh',
                type: 'array',
                data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'Trên 10'],
                unit: 'toilet',
            },
            {
                key: 'huongBanCong',
                label: 'Hướng ban công',
                type: 'array',
                data: [
                    'Đông',
                    'Tây',
                    'Nam',
                    'Bắc',
                    'Đông Bắc',
                    'Đông Nam',
                    'Tây Bắc',
                    'Tây Nam',
                ],
            },
            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    'Đông',
                    'Tây',
                    'Nam',
                    'Bắc',
                    'Đông Bắc',
                    'Đông Nam',
                    'Tây Bắc',
                    'Tây Nam',
                ],
            },
        ],
    },
    {
        categoryId: 1,
        subCategoryId: 14,
        filterParams: [
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
                    'Nhà mặt phố, mặt tiền',
                    'Nhà ngỏ, hẻm',
                    'Nhà biệt thự',
                    'Nhà phố liền kề',
                ],
            },
            {
                key: 'soPhongNgu',
                label: 'Số phòng ngủ',
                type: 'array',
                data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'Trên 10'],
                unit: 'phòng ngủ',
            },
            {
                key: 'soToilet',
                label: 'Số phòng vệ sinh',
                type: 'array',
                data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'Trên 10'],
                unit: 'toilet',
            },

            {
                key: 'huongCuaChinh',
                label: 'Hướng cửa chính',
                type: 'array',
                data: [
                    'Đông',
                    'Tây',
                    'Nam',
                    'Bắc',
                    'Đông Bắc',
                    'Đông Nam',
                    'Tây Bắc',
                    'Tây Nam',
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
