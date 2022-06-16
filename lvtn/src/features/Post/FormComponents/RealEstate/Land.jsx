import React from 'react'
import styles from './index.module.css'
import FormGroup from '../Components/FormGroup'
import FormInput from '../Components/FormInput'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Land({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ BĐS và Hình ảnh */}
            <FormGroup title='Địa chỉ BĐS và Hình ảnh'>
                <div className={styles.group}>
                    <FormInput
                        label='Tên dự án đất nền'
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
            </FormGroup> */}

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        label='Loại hình đất'
                        require
                        value={formData.datLoaiHinhDat}
                        onChange={e =>
                            handleFormDataChange(
                                'datLoaiHinhDat',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Đất thổ cư' },
                            { value: 'Đất dự án nền ' },
                            { value: 'Đất công nghiệp' },
                            { value: 'Đất nông nghiệp' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Hướng đất (không bắt buộc)'
                            halfContainer
                            value={formData.datHuongDat}
                            onChange={e =>
                                handleFormDataChange(
                                    'datHuongDat',
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
                            value={formData.datGiayToPhapLy}
                            onChange={e =>
                                handleFormDataChange(
                                    'datGiayToPhapLy',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Đã có sổ' },
                                { value: 'Chưa có sổ' },
                                { value: 'Giấy tờ khác' },
                            ]}
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
                                    checked={formData.datHemXeHoi}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'datHemXeHoi',
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
                                    checked={formData.datNoHau}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'datNoHau',
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
                                    checked={formData.datMatTien}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'datMatTien',
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

                    <div className={styles.halfParent}>
                        <FormInput
                            label={'Chiều ngang'}
                            halfContainer
                            value={formData.datChieuNgang}
                            onChange={e =>
                                handleFormDataChange(
                                    'datChieuNgang',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            label={'Chiều dài'}
                            halfContainer
                            value={formData.datChieuDai}
                            onChange={e =>
                                handleFormDataChange(
                                    'datChieuDai',
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

export default Land
