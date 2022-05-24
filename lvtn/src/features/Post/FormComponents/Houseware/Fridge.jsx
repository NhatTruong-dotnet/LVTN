import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function Fridge({ formData, handleFormDataChange }) {
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
                        label='Hãng'
                        value={formData.hang}
                        onChange={e =>
                            handleFormDataChange('hang', e.target.value)
                        }
                        requireData={[
                            { value: 'Sanyo' },
                            { value: 'Toshiba ' },
                            { value: 'Panasonic' },
                            { value: 'Sanaky' },
                            { value: 'Samsung' },
                            { value: 'LG' },
                            { value: 'Sharp' },
                            { value: 'Alaska' },
                            { value: 'Hitachi' },
                            { value: 'Electrolux' },
                            { value: 'Daikin' },
                            { value: 'Funiki' },
                            { value: 'Daewoo' },
                            { value: 'Beko' },
                            { value: 'Mitsubishi' },
                            { value: 'Hãng khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Thể tích'
                        value={formData.tuLanhTheTich}
                        onChange={e =>
                            handleFormDataChange(
                                'tuLanhTheTich',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: '<100 lít' },
                            { value: '100 - 149 lít ' },
                            { value: '150 - 199 lít' },
                            { value: '200 - 299 lít' },
                            { value: '300 - 399 lít' },
                            { value: '400 - 499 lít' },
                            { value: '>500 lít' },
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

export default Fridge
