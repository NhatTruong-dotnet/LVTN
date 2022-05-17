// chung cư
import styles from './index.module.css'
import clsx from 'clsx'
import FormInput from './Components/FormInput'
import FormGroup from './Components/FormGroup'

function Apartment({ formData, handleFormDataChange }) {
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

            {/* Vị trí BĐS */}
            <FormGroup title='Vị trí BĐS'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Mã căn'
                            halfContainer
                            value={formData.apartmentId}
                            onChange={e =>
                                handleFormDataChange(
                                    'apartmentId',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label='Block / Tháp'
                            halfContainer
                            value={formData.block}
                            onChange={e =>
                                handleFormDataChange('block', e.target.value)
                            }
                        />
                    </div>

                    <div className={styles.halfParent}>
                        <FormInput
                            label='Tầng số'
                            type='number'
                            halfContainer
                            value={formData.floor}
                            onChange={e =>
                                handleFormDataChange('floor', e.target.value)
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
                        label='Loại hình căn hộ'
                        value={formData.apartmentType}
                        onChange={e =>
                            handleFormDataChange(
                                'apartmentType',
                                e.target.value
                            )
                        }
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Số phòng ngủ'
                            halfContainer
                            value={formData.amountBedroom}
                            onChange={e =>
                                handleFormDataChange(
                                    'amountBedroom',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            require
                            label='Số phòng vệ sinh'
                            halfContainer
                            value={formData.amountToilet}
                            onChange={e =>
                                handleFormDataChange(
                                    'amountToilet',
                                    e.target.value
                                )
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Hướng ban công (Không bắt buộc)'
                            halfContainer
                            value={formData.balcony}
                            onChange={e =>
                                handleFormDataChange('balcony', e.target.value)
                            }
                        />

                        <FormInput
                            label='Hướng cửa chính (Không bắt buộc)'
                            halfContainer
                            value={formData.mainDoor}
                            onChange={e =>
                                handleFormDataChange('mainDoor', e.target.value)
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
                            label='Giấy tờ pháp lý (Không bắt buộc)'
                            halfContainer
                            value={formData.exhibit}
                            onChange={e =>
                                handleFormDataChange('exhibit', e.target.value)
                            }
                        />

                        <FormInput
                            label='Tình trạng nội thất (Không bắt buộc)'
                            halfContainer
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
                        require
                        type='number'
                        unit='m²'
                        label='Diện tích'
                        value={formData.acreage}
                        onChange={e =>
                            handleFormDataChange('acreage', e.target.value)
                        }
                    />

                    <FormInput
                        require
                        type='number'
                        unit='đ'
                        label='Giá'
                        value={formData.price}
                        onChange={e =>
                            handleFormDataChange('price', e.target.value)
                        }
                    />

                    {!formData?.isSell && (
                        <FormInput
                            require
                            label='Số tiền cọc'
                            value={formData.deposit}
                            onChange={e =>
                                handleFormDataChange('deposit', e.target.value)
                            }
                        />
                    )}
                </div>
            </FormGroup>
        </>
    )
}

export default Apartment
