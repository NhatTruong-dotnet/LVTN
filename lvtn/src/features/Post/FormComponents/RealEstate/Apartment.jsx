// chung cư
import styles from './index.module.css'
import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'

function Apartment({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên tòa nhà / Khu dân cư / dự án'
                        value={formData.tenDuAn}
                        onChange={e =>
                            handleFormDataChange('tenDuAn', e.target.value)
                        }
                        test
                    />
                </div>
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

            {/* Vị trí BĐS */}
            <FormGroup title='Vị trí BĐS'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Mã căn'
                            halfContainer
                            value={formData.maCan}
                            onChange={e =>
                                handleFormDataChange('maCan', e.target.value)
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
                            value={formData.tangSo}
                            onChange={e =>
                                handleFormDataChange('tangSo', e.target.value)
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
                        value={formData.loaiHinh}
                        onChange={e =>
                            handleFormDataChange('loaiHinh', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Số phòng ngủ'
                            halfContainer
                            value={formData.soPhongNgu}
                            onChange={e =>
                                handleFormDataChange(
                                    'soPhongNgu',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            require
                            label='Số phòng vệ sinh'
                            halfContainer
                            value={formData.soToilet}
                            onChange={e =>
                                handleFormDataChange('soToilet', e.target.value)
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Hướng ban công (Không bắt buộc)'
                            halfContainer
                            value={formData.ccBanCong}
                            onChange={e =>
                                handleFormDataChange(
                                    'ccBanCong',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label='Hướng cửa chính (Không bắt buộc)'
                            halfContainer
                            value={formData.ccHuongCuaChinh}
                            onChange={e =>
                                handleFormDataChange(
                                    'ccHuongCuaChinh',
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
                            halfContainer
                            value={formData.ccGiayToPhapLy}
                            onChange={e =>
                                handleFormDataChange(
                                    'ccGiayToPhapLy',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label='Tình trạng nội thất (Không bắt buộc)'
                            halfContainer
                            value={formData.ccTinhTrangNoiThat}
                            onChange={e =>
                                handleFormDataChange(
                                    'ccTinhTrangNoiThat',
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
                        value={formData.dienTich}
                        onChange={e =>
                            handleFormDataChange('dienTich', e.target.value)
                        }
                    />

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

                    {!formData?.isSell && (
                        <FormInput
                            require
                            label='Số tiền cọc'
                            value={formData.soTienCoc}
                            onChange={e =>
                                handleFormDataChange(
                                    'soTienCoc',
                                    e.target.value
                                )
                            }
                        />
                    )}
                </div>
            </FormGroup>
        </>
    )
}

export default Apartment
