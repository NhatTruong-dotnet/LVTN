import styles from './index.module.css'
import clsx from 'clsx'
import FormGroup from '../Components/FormGroup'
import FormInput from '../Components/FormInput'

function House({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên Khu dân cư / dự án'
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
                            value={formData.houseId}
                            onChange={e =>
                                handleFormDataChange('houseId', e.target.value)
                            }
                        />

                        <FormInput
                            label='Tên phân khu / lô'
                            value={formData.block}
                            onChange={e =>
                                handleFormDataChange('block', e.target.value)
                            }
                        />
                    </div>
                </div>
            </FormGroup>

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        label='Loại hình nhà ở'
                        require
                        value={formData.houseType}
                        onChange={e =>
                            handleFormDataChange('houseType', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Số phòng ngủ'
                            require
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
                            label='Số phòng vệ sinh(Không bắt buộc)'
                            require
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
                            label='Tổng số tầng'
                            value={formData.floor}
                            onChange={e =>
                                handleFormDataChange('floor', e.target.value)
                            }
                        />

                        <FormInput
                            label='Hướng cửa chính (Không bắt buộc)'
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
                            value={formData.exhibit}
                            onChange={e =>
                                handleFormDataChange('exhibit', e.target.value)
                            }
                        />
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

                    <div className={styles.special}>
                        <div className={styles.title}>Đặc điểm nhà / đất</div>
                        <div className={styles.checkboxGroup}>
                            <label className={styles.checkboxLabel}>
                                Hẻm xe hơi
                            </label>
                            <input
                                type='checkbox'
                                id='car'
                                checked={formData.isAlley}
                                onChange={e =>
                                    handleFormDataChange(
                                        'isAlley',
                                        e.target.checked
                                    )
                                }
                            />
                        </div>
                        <div className={styles.checkboxGroup}>
                            <label className={styles.checkboxLabel}>
                                Nở hậu
                            </label>
                            <input
                                type='checkbox'
                                id='car'
                                checked={formData.hasBackyard}
                                onChange={e =>
                                    handleFormDataChange(
                                        'hasBackyard',
                                        e.target.checked
                                    )
                                }
                            />
                        </div>
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
                        label='Diện tích sử dụng'
                        value={formData.useAcreage}
                        onChange={e =>
                            handleFormDataChange('useAcreage', e.target.value)
                        }
                    />

                    <div className={styles.halfParent}>
                        <FormInput
                            label={'Chiều ngang'}
                            halfContainer
                            value={formData.horizontal}
                            onChange={e =>
                                handleFormDataChange(
                                    'horizontal',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label={'Chiều dài'}
                            halfContainer
                            value={formData.vertical}
                            onChange={e =>
                                handleFormDataChange('vertical', e.target.value)
                            }
                        />
                    </div>

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

export default House
