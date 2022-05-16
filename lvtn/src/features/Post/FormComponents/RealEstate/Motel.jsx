import styles from './index.module.css'
import FormGroup from './Components/FormGroup'
import FormInput from './Components/FormInput'

function Motel({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên tòa nhà / Khu dân cư / dự án'
                        value={formData.name}
                        onChange={e =>
                            handleFormDataChange('name', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Chọn thành phố'
                            require
                            halfContainer
                            value={formData.address.city}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    city: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Chọn quận, huyện, thị xã'
                            halfContainer
                            value={formData.address.district}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    district: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Chọn xã, phường, thị trấn'
                            halfContainer
                            value={formData.address.ward}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    ward: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Tên đường'
                            halfContainer
                            value={formData.address.street}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    street: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Số nhà'
                            halfContainer
                            value={formData.address.number}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    number: e.target.value,
                                })
                            }
                        />
                    </div>
                </div>
            </FormGroup>

            {/* Thông tin khác */}
            <FormGroup title='Thông tin khác'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Tình trạng nội thất (Không bắt buộc)'
                            value={formData.furniture}
                            onChange={e =>
                                handleFormDataChange(
                                    'furniture',
                                    e.target.value
                                )
                            }
                        />
                    </div>
                </div>
            </FormGroup>

            {/* Diện tích và giá */}
            <FormGroup title='Diện tích và giá'>
                <div className={styles.group}>
                    <FormInput
                        label='Diện tích đất'
                        require
                        value={formData.acreage}
                        onChange={e =>
                            handleFormDataChange('acreage', e.target.value)
                        }
                    />

                    <FormInput
                        label={'Giá'}
                        require
                        value={formData.price}
                        onChange={e =>
                            handleFormDataChange('price', e.target.value)
                        }
                    />

                    <FormInput
                        label={'Số tiền cọc'}
                        require
                        value={formData.deposit}
                        onChange={e =>
                            handleFormDataChange('deposit', e.target.value)
                        }
                    />
                </div>
            </FormGroup>
        </>
    )
}

export default Motel
