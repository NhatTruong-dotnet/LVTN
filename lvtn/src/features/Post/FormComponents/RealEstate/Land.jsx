import React from 'react'
import styles from './index.module.css'
import FormGroup from './Components/FormGroup'
import FormInput from './Components/FormInput'

function Land({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên dự án đất nền'
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
                            label='Mã lô'
                            value={formData.landId}
                            onChange={e =>
                                handleFormDataChange('landId', e.target.value)
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
                        label='Loại hình đất'
                        require
                        value={formData.landType}
                        onChange={e =>
                            handleFormDataChange('landType', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Hướng đất (không bắt buộc)'
                            halfContainer
                            value={formData.landDirection}
                            onChange={e =>
                                handleFormDataChange(
                                    'landDirection',
                                    e.target.value
                                )
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
                    </div>

                    <div className={styles.special}>
                        <div className={styles.title}>Đặc điểm nhà / đất</div>
                        <div className={styles.wrap}>
                            <div className={styles.checkboxGroup}>
                                <label
                                    className={styles.checkboxLabel}
                                    htmlFor='1'
                                >
                                    Hẻm xe hơi
                                </label>
                                <input
                                    type='checkbox'
                                    id='1'
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
                                <label
                                    className={styles.checkboxLabel}
                                    htmlFor='2'
                                >
                                    Nở hậu
                                </label>
                                <input
                                    type='checkbox'
                                    id='2'
                                    checked={formData.hasBackyard}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'hasBackyard',
                                            e.target.checked
                                        )
                                    }
                                />
                            </div>
                            <div className={styles.checkboxGroup}>
                                <label
                                    className={styles.checkboxLabel}
                                    htmlFor='3'
                                >
                                    Mặt tiền
                                </label>
                                <input
                                    type='checkbox'
                                    id='3'
                                    checked={formData.isFacade}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'isFacade',
                                            e.target.checked
                                        )
                                    }
                                />
                            </div>
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

export default Land
