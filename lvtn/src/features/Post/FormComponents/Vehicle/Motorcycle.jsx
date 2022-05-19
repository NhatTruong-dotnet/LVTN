import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function Motorcycle({ formData, handleFormDataChange }) {
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

            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng'
                        value={formData.hangXe}
                        onChange={e =>
                            handleFormDataChange('hangXe', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng xe'
                        halfContainer
                        value={formData.dongXe}
                        onChange={e =>
                            handleFormDataChange('dongXe', e.target.value)
                        }
                    />

                    <FormInput
                        require
                        label='Năm đăng ký'
                        halfContainer
                        value={formData.nam}
                        onChange={e =>
                            handleFormDataChange('nam', e.target.value)
                        }
                    />
                    <FormInput
                        require
                        label='Loại xe'
                        halfContainer
                        value={formData.xeMayLoaiXe}
                        onChange={e =>
                            handleFormDataChange('xeMayLoaiXe', e.target.value)
                        }
                    />
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Dung tích xe (Không bắt buộc)'
                            halfContainer
                            value={formData.xeMayDungtich}
                            onChange={e =>
                                handleFormDataChange(
                                    'xeMayDungtich',
                                    e.target.value
                                )
                            }
                        />

                        {formData.daSuDung && (
                            <FormInput
                                label='Biển số xe'
                                halfContainer
                                value={formData.bienSoXe}
                                onChange={e =>
                                    handleFormDataChange(
                                        'bienSoXe',
                                        e.target.value
                                    )
                                }
                            />
                        )}
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
                    Xe mới
                </div>
                <div className={styles.formMessage}></div>
            </div>

            {formData.daSuDung && (
                <div className={styles.group}>
                    <FormInput
                        require
                        type='number'
                        unit='km'
                        label='Số km đã đi'
                        value={formData.soKmDaDi}
                        onChange={e =>
                            handleFormDataChange('soKmDaDi', e.target.value)
                        }
                    />
                </div>
            )}
            <div className={styles.group}>
                <FormInput
                    require
                    type='number'
                    unit='đ'
                    label='Giá'
                    value={formData.gia}
                    onChange={e => handleFormDataChange('gia', e.target.value)}
                />
            </div>
        </>
    )
}

export default Motorcycle
