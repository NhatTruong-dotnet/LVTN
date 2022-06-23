import styles from './index.module.css'
import FormGroup from '../Components/FormGroup'
import FormInput from '../Components/FormInput'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Motel({ formData, handleFormDataChange }) {
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
                    />
                </div>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>

            {/* Thông tin khác */}
            <FormGroup title='Thông tin khác'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Tình trạng nội thất (Không bắt buộc)'
                            value={formData.phongTroTinhTrangNoiThat}
                            onChange={e =>
                                handleFormDataChange(
                                    'phongTroTinhTrangNoiThat',
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
                </div>
            </FormGroup>

            {/* Diện tích và giá */}
            <FormGroup title='Diện tích và giá'>
                <div className={styles.group}>
                    <FormInput
                        label='Diện tích'
                        require
                        value={formData.dienTich}
                        onChange={e =>
                            handleFormDataChange('dienTich', e.target.value)
                        }
                    />

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
                        value={formData.phongTroSoTienCoc}
                        onChange={e =>
                            handleFormDataChange(
                                'phongTroSoTienCoc',
                                e.target.value
                            )
                        }
                    />
                </div>
            </FormGroup>
        </>
    )
}

export default Motel
