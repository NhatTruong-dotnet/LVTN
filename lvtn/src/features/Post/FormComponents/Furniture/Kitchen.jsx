import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Bed({ formData, handleFormDataChange }) {
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
                            { value: 'Máy pha cà phê' },
                            { value: 'Nồi cơm điện' },
                            { value: 'Nồi áp suất' },
                            { value: 'Nồi lẩu điện' },
                            { value: 'Nồi chiên không dầu' },
                            { value: 'Lò nướng' },
                            { value: 'Lò vi sóng' },
                            { value: 'Máy xay' },
                            { value: 'Máy ép trái cây' },
                            { value: 'Máy đánh trứng' },
                            { value: 'Máy đun' },
                            { value: 'Bếp' },
                            { value: 'Bếp từ' },
                            { value: 'Bếp hồng ngoại' },
                            { value: 'Bếp nướng điện' },
                            { value: 'Máy lọc nước' },
                            { value: 'Máy hút mùi' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Kích cỡ'
                        value={formData.bepThuongHieu}
                        onChange={e =>
                            handleFormDataChange(
                                'bepThuongHieu',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Sharp' },
                            { value: 'Panasonic' },
                            { value: 'Toshiba' },
                            { value: 'Sunhouse' },
                            { value: 'Bluestone' },
                            { value: 'Midea' },
                            { value: 'Phillips' },
                            { value: 'Kangaroo' },
                            { value: 'Hitachi' },
                            { value: 'Electrolux' },
                            { value: 'Sanaky' },
                            { value: 'Rinnai' },
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

export default Bed
