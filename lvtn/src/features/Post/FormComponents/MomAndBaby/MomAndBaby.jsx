import styles from '../RealEstate/index.module.css'
import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import clsx from 'clsx'

function MomAndBaby({ formData, handleFormDataChange }) {
    console.log('running')
    console.log(formData)
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
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Loại sản phẩm'
                        value={formData.loaiSanPham}
                        onChange={e =>
                            handleFormDataChange('loaiSanPham', e.target.value)
                        }
                        requireData={[
                            { value: 'Cho mẹ' },
                            { value: 'Cho bé' },
                            { value: 'Cả hai' },
                        ]}
                    />
                </div>
            </FormGroup>
            <div className={styles.group}>
                <input
                    type='checkbox'
                    id='isFree'
                    checked={formData.mienPhi}
                    onChange={e =>
                        handleFormDataChange('mienPhi', e.target.checked)
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
        </>
    )
}

export default MomAndBaby
