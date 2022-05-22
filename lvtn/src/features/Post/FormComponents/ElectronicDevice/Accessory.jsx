import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'

function Accessory({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ và hình ảnh */}
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Chọn thành phố'
                            require
                            halfContainer
                            value={formData.address?.thanhPho}
                            onChange={e => {
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    thanhPho: e.target.value,
                                })
                            }}
                        />

                        <FormInput
                            require
                            label='Chọn quận, huyện, thị xã'
                            halfContainer
                            value={formData.address?.quanHuyen}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    quanHuyen: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Chọn xã, phường, thị trấn'
                            halfContainer
                            value={formData.address?.phuongXa}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    phuongXa: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Tên đường'
                            halfContainer
                            value={formData.address?.tenDuong}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    tenDuong: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Số nhà'
                            halfContainer
                            value={formData.address?.soNha}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    soNha: e.target.value,
                                })
                            }
                        />
                    </div>
                </div>
            </FormGroup>

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <FormInput
                    require
                    label='Loại phụ kiện'
                    value={formData.phuKienLoaiPhuKien}
                    onChange={e =>
                        handleFormDataChange(
                            'phuKienLoaiPhuKien',
                            e.target.value
                        )
                    }
                    requireData={[
                        { value: 'Phụ kiện máy tính' },
                        { value: 'Phụ kiện điện thoại' },
                        { value: 'Khác' },
                    ]}
                />
                {formData.phuKienLoaiPhuKien && (
                    <FormInput
                        require
                        label='Thiết bị'
                        value={formData.phuKienThietBi}
                        onChange={e =>
                            handleFormDataChange(
                                'phuKienThietBi',
                                e.target.value
                            )
                        }
                        // requireData={() => {
                        //     if (!formData) return []
                        //     if (
                        //         formData.phuKienLoaiPhuKien ===
                        //         'Phụ kiện máy tính'
                        //     ) {
                        //         return [
                        //             { value: 'Màn hình' },
                        //             { value: 'Bàn phím' },
                        //             { value: 'Chuột' },
                        //             { value: 'Khác' },
                        //         ]
                        //     } else if (
                        //         formData.phuKienLoaiPhuKien ===
                        //         'Phụ kiện điện thoại'
                        //     ) {
                        //         return [
                        //             { value: 'Ốp' },
                        //             { value: 'Dán màn hình' },
                        //             { value: 'Khác' },
                        //         ]
                        //     } else {
                        //         return []
                        //     }
                        // }}
                    />
                )}

                <div className={styles.group}>
                    <div className={styles.group}>
                        <FormInput
                            require
                            label='Tình trạng'
                            halfContainer
                            value={formData.tinhTrang}
                            onChange={e =>
                                handleFormDataChange(
                                    'tinhTrang',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Mới' },
                                { value: 'Đã sử dụng (chưa sửa chữa)' },
                                { value: 'Đã sử dụng (đã sửa chữa)' },
                            ]}
                        />
                    </div>

                    <FormInput
                        require
                        label='Bảo hành'
                        halfContainer
                        value={formData.baoHanh}
                        onChange={e =>
                            handleFormDataChange('baoHanh', e.target.value)
                        }
                        requireData={[
                            { value: 'Còn bảo hành' },
                            { value: 'Hết bảo hành' },
                        ]}
                    />

                    <div className={styles.group}>
                        <input
                            type='checkbox'
                            id='isFree'
                            checked={formData.mienPhi}
                            onChange={e =>
                                handleFormDataChange(
                                    'mienPhi',
                                    e.target.checked
                                )
                            }
                        />
                        <label htmlFor='isFree'>Cho tặng miễn phí</label>
                    </div>
                    {!formData.mienPhi && (
                        <div className={styles.group}>
                            <FormInput
                                require
                                type='number'
                                unit='đ'
                                label='Giá'
                                value={formData.gia}
                                onChange={e =>
                                    handleFormDataChange('gia', e.target.value)
                                }
                            />
                        </div>
                    )}
                </div>
            </FormGroup>
        </>
    )
}

export default Accessory
