import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function Cabinet({ formData, handleFormDataChange }) {
    return (
        <>
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Chọn thành phố'
                            require
                            halfContainer
                            value={formData.address.thanhPho}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    thanhPho: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Chọn quận, huyện, thị xã'
                            halfContainer
                            value={formData.address.quanHuyen}
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
                            value={formData.address.phuongXa}
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
                            value={formData.address.tenDuong}
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
                            value={formData.address.soNha}
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
                            { value: 'Tủ, kệ quần áo' },
                            { value: 'Tủ, kệ sách' },
                            { value: 'Tủ, kệ giày dép' },
                            { value: 'Tủ, kệ tivi' },
                            { value: 'Tủ, kệ bếp' },
                            { value: 'Tủ, kệ đầu giường' },
                            { value: 'Tủ, kệ trưng bày' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Chất liệu'
                        value={formData.tuKeChatLieu}
                        onChange={e =>
                            handleFormDataChange('tuKeChatLieu', e.target.value)
                        }
                        requireData={[
                            { value: 'Gỗ' },
                            { value: 'Nhựa' },
                            { value: 'Sắt' },
                            { value: 'Inox' },
                            { value: 'Đá' },
                            { value: 'Kính' },
                            { value: 'vải' },
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

export default Cabinet
