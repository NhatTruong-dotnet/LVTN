import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Tablet({ formData, handleFormDataChange }) {
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
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng'
                        value={formData.mayTinhBangHang}
                        onChange={e =>
                            handleFormDataChange(
                                'mayTinhBangHang',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Apple' },
                            { value: 'Samsung' },
                            { value: 'Asus' },
                            { value: 'Xiaomi' },
                            { value: 'Acer' },
                            { value: 'Huawei' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng máy'
                        value={formData.mayTinhBangDongMay}
                        onChange={e =>
                            handleFormDataChange(
                                'mayTinhBangDongMay',
                                e.target.value
                            )
                        }
                    />
                </div>
                <div className={styles.type}>
                    <div className={styles.title}>
                        Phiên bản <span className={styles.required}>*</span>
                    </div>
                    <div
                        onClick={() =>
                            handleFormDataChange('mayTinhBangQuocTe', true)
                        }
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                formData.mayTinhBangQuocTe &&
                                formData.mayTinhBangQuocTe !== null,
                        })}
                    >
                        Quốc tế
                    </div>
                    <div
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                !formData.mayTinhBangQuocTe &&
                                formData.mayTinhBangQuocTe !== null,
                        })}
                        onClick={() =>
                            handleFormDataChange('mayTinhBangQuocTe', false)
                        }
                    >
                        Khóa mạng (lock)
                    </div>
                    <div className={styles.formMessage}></div>
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Tình trạng'
                        halfContainer
                        value={formData.tinhTrang}
                        onChange={e =>
                            handleFormDataChange('tinhTrang', e.target.value)
                        }
                        requireData={[
                            { value: 'Mới' },
                            { value: 'Đã sử dụng (chưa sửa chữa)' },
                            { value: 'Đã sử dụng (đã sửa chữa)' },
                        ]}
                    />

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
                    <FormInput
                        label='Sử dụng simcard 3G/4G (Không bắt buộc)'
                        halfContainer
                        value={formData.mayTinhBang4g}
                        onChange={e =>
                            handleFormDataChange(
                                'mayTinhBang4g',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Còn bảo hành' },
                            { value: 'Hết bảo hành' },
                        ]}
                    />
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Kích cỡ màn hình'
                            halfContainer
                            value={formData.mayTinhBangKichCoManHinh}
                            onChange={e =>
                                handleFormDataChange(
                                    'mayTinhBangKichCoManHinh',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: '< 7 inch' },
                                { value: '7 - 7.9 inch' },
                                { value: '8 - 8.9 inch' },
                                { value: '9 - 9.9 inch' },
                                { value: '> 10 inch' },
                            ]}
                        />

                        <FormInput
                            label='Dung lượng'
                            halfContainer
                            value={formData.mayTinhBangDungLuong}
                            onChange={e =>
                                handleFormDataChange(
                                    'mayTinhBangDungLuong',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: '< 8GB' },
                                { value: '8GB' },
                                { value: '16GB' },
                                { value: '32GB' },
                                { value: '64GB' },
                                { value: '128GB' },
                                { value: '256GB' },
                                { value: '> 256GB' },
                            ]}
                        />
                    </div>
                    <div>
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
                </div>
            </FormGroup>
        </>
    )
}

export default Tablet
