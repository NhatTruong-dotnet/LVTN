import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'

function Cat({ formData, handleFormDataChange }) {
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
                        label='Giống thú cưng'
                        value={formData.giongThuCung}
                        onChange={e =>
                            handleFormDataChange('giongThuCung', e.target.value)
                        }
                        requireData={[
                            { value: 'Mèo anh lông dài' },
                            { value: 'Mèo anh lông ngắn' },
                            { value: 'Mèo ba tư' },
                            { value: 'Mèo bengal' },
                            { value: 'Mèo golden' },
                            { value: 'Mèo Munchkin' },
                            { value: 'Mèo mướp' },
                            { value: 'Mèo mỹ' },
                            { value: 'Mèo Nga' },
                            { value: 'Mèo Ragdoll' },
                            { value: 'Mèo scottish' },
                            { value: 'Mèo sphynx' },
                            { value: 'Mèo ta' },
                            { value: 'Mèo tam thể' },
                            { value: 'Mèo Tuxedo' },
                            { value: 'Mèo xiêm' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Độ tuổi'
                        value={formData.doTuoi}
                        onChange={e =>
                            handleFormDataChange('doTuoi', e.target.value)
                        }
                        requireData={[
                            { value: 'Mèo con(dưới 3 tháng tuổi)' },
                            { value: 'Mèo nhỏ(dưới 1 năm tuổi)' },
                            { value: 'Mèo trưởng thành(hơn 1 tuổi)' },
                            { value: 'Khác(không xác định được)' },
                        ]}
                    />
                </div>
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
            </FormGroup>
        </>
    )
}

export default Cat
