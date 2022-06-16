import styles from './index.module.css'
import clsx from 'clsx'
import FormGroup from '../Components/FormGroup'
import FormInput from '../Components/FormInput'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function House({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên Khu dân cư / dự án'
                        value={formData.tenDuAn}
                        onChange={e =>
                            handleFormDataChange('tenDuAn', e.target.value)
                        }
                    />
                </div>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>

            {/* Vị trí BĐS */}
            {/* <FormGroup title='Vị trí BĐS'>
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
            </FormGroup> */}

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        label='Loại hình nhà ở'
                        require
                        value={formData.loaiHinh}
                        onChange={e =>
                            handleFormDataChange('loaiHinh', e.target.value)
                        }
                        requireData={[
                            { value: 'Nhà mặt phố, mặt tiền' },
                            { value: 'Nhà ngõ, hẻm' },
                            { value: 'Nhà biệt thự' },
                            { value: 'Nhà phố liền kề' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Số phòng ngủ'
                            require
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
                            label='Số phòng vệ sinh(Không bắt buộc)'
                            require
                            halfContainer
                            value={formData.soToilet}
                            onChange={e =>
                                handleFormDataChange('soToilet', e.target.value)
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Tổng số tầng'
                            value={formData.soTang}
                            onChange={e =>
                                handleFormDataChange('soTang', e.target.value)
                            }
                        />

                        <FormInput
                            label='Hướng cửa chính (Không bắt buộc)'
                            value={formData.nhaOHuongCuaChinh}
                            onChange={e =>
                                handleFormDataChange(
                                    'nhaOHuongCuaChinh',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Đông' },
                                { value: 'Tây' },
                                { value: 'Nam' },
                                { value: 'Bắc' },
                                { value: 'Đông Bắc' },
                                { value: 'Đông Nam' },
                                { value: 'Tây Bắc' },
                                { value: 'Tây Nam' },
                            ]}
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
                            value={formData.nhaOGiayToPhapLy}
                            onChange={e =>
                                handleFormDataChange(
                                    'nhaOGiayToPhapLy',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Đã có sổ' },
                                { value: 'Chưa có sổ' },
                                { value: 'Giấy tờ khác' },
                            ]}
                        />
                        <FormInput
                            label='Tình trạng nội thất (Không bắt buộc)'
                            value={formData.nhaOTinhTrangNoiThat}
                            onChange={e =>
                                handleFormDataChange(
                                    'nhaOTinhTrangNoiThat',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Nội thất cao cấp' },
                                { value: 'Nội thất đầy đủ' },
                                { value: 'Hoàn thiện cơ bản' },
                                { value: 'Bàn giao thô' },
                            ]}
                        />
                    </div>

                    <div className={styles.special}>
                        <div className={styles.title}>Đặc điểm nhà / đất</div>
                        <div className={styles.wrap}>
                            <div className={styles.checkboxGroup}>
                                <label className={styles.checkboxLabel}>
                                    Hẻm xe hơi
                                </label>
                                <input
                                    type='checkbox'
                                    id='car'
                                    checked={formData.nhaOhemXeHoi}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'nhaOhemXeHoi',
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
                                    checked={formData.nhaOnoHau}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'nhaOnoHau',
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
                        value={formData.dienTich}
                        onChange={e =>
                            handleFormDataChange('dienTich', e.target.value)
                        }
                    />

                    <FormInput
                        label='Diện tích sử dụng'
                        value={formData.dienTichSuDung}
                        onChange={e =>
                            handleFormDataChange(
                                'dienTichSuDung',
                                e.target.value
                            )
                        }
                    />

                    <div className={styles.halfParent}>
                        <FormInput
                            label={'Chiều ngang'}
                            halfContainer
                            value={formData.nhaOchieuNgang}
                            onChange={e =>
                                handleFormDataChange(
                                    'nhaOchieuNgang',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label={'Chiều dài'}
                            halfContainer
                            value={formData.nhaOchieuDai}
                            onChange={e =>
                                handleFormDataChange(
                                    'nhaOchieuDai',
                                    e.target.value
                                )
                            }
                        />
                    </div>

                    <FormInput
                        label={'Giá'}
                        require
                        value={formData.gia}
                        onChange={e =>
                            handleFormDataChange('gia', e.target.value)
                        }
                    />

                    <FormInput
                        label={'Số tiền cọc'}
                        require
                        value={formData.soTienCoc}
                        onChange={e =>
                            handleFormDataChange('soTienCoc', e.target.value)
                        }
                    />
                </div>
            </FormGroup>
        </>
    )
}

export default House
