import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function SmartDevice({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ và hình ảnh */}
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <FormInput
                    require
                    label='Thiết bị'
                    value={formData.thietBiDeoThongMinhThietBi}
                    onChange={e =>
                        handleFormDataChange(
                            'thietBiDeoThongMinhThietBi',
                            e.target.value
                        )
                    }
                    requireData={[
                        { value: 'Đồng hồ thông minh' },
                        { value: 'Vòng tay thông minh' },
                        { value: 'Khác' },
                    ]}
                />
                <FormInput
                    require
                    label='Hãng'
                    value={formData.thietBiDeoThongMinhHang}
                    onChange={e =>
                        handleFormDataChange(
                            'thietBiDeoThongMinhHang',
                            e.target.value
                        )
                    }
                    requireData={[
                        { value: 'Apple' },
                        { value: 'Samsung' },
                        { value: 'Xiaomi' },
                        { value: 'Fitbit' },
                        { value: 'Misfit' },
                        { value: 'Garmin' },
                        { value: 'Huawei' },
                        { value: 'Khác' },
                    ]}
                />

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

export default SmartDevice
