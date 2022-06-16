import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Fan({ formData, handleFormDataChange }) {
    return (
        <>
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>
            <div className={styles.type}>
                <div className={styles.title}>
                    Tình trạng <span className={styles.required}>*</span>
                </div>
                <div
                    onClick={() => handleFormDataChange('daSuDung', true)}
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            formData.daSuDung && formData.daSuDung !== null,
                    })}
                >
                    Đã sử dụng
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            !formData.daSuDung && formData.daSuDung !== null,
                    })}
                    onClick={() => handleFormDataChange('daSuDung', false)}
                >
                    mới
                </div>
                <div className={styles.formMessage}></div>
            </div>
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Loại sản phẩm'
                        value={formData.loaiSanPham}
                        onChange={e =>
                            handleFormDataChange('loaiSanPham', e.target.value)
                        }
                        requireData={[
                            { value: 'Quạt hơi nước' },
                            { value: 'Quạt điều hòa' },
                            { value: 'Quạt đứng' },
                            { value: 'Quạt treo tường' },
                            { value: 'Quạt hộp' },
                            { value: 'Quạt trần' },
                            { value: 'Quạt sạc điện/Quạt mini' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Thương hiệu'
                        value={formData.quatThuongHieu}
                        onChange={e =>
                            handleFormDataChange(
                                'quatThuongHieu',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Asia' },
                            { value: 'Sunhouse' },
                            { value: 'Toshiba' },
                            { value: 'Panasonic' },
                            { value: 'Kangaroo' },
                            { value: 'Midea' },
                            { value: 'Senko' },
                            { value: 'Boxx' },
                            { value: 'Mitsubishi' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
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

export default Fan
