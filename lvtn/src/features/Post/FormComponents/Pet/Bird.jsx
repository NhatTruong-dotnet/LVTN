import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Bird({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ và hình ảnh */}
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
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
                            { value: 'Chim bồ câu' },
                            { value: 'Chim chào mào' },
                            { value: 'Chim chích chòe' },
                            { value: 'Chim cu gáy' },
                            { value: 'Chim họa mi' },
                            { value: 'Chim hoàng yến' },
                            { value: 'Chim Khướu' },
                            { value: 'Chim sáo' },
                            { value: 'Chim sâu' },
                            { value: 'Chim sẻ' },
                            { value: 'Chim sơn ca' },
                            { value: 'Chim vàng anh' },
                            { value: 'Chim vành khuyên' },
                            { value: 'Chim vẹt' },
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
                            { value: 'Chim nhỏ(dưới 3 tháng tuổi)' },
                            { value: 'Chim lớn(từ 3 tháng tuổi)' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Giới tính'
                        value={formData.chimGioiTinh}
                        onChange={e =>
                            handleFormDataChange('chimGioiTinh', e.target.value)
                        }
                        requireData={[
                            { value: 'Chim trống' },
                            { value: 'Chim mái' },
                            { value: 'khác' },
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

export default Bird
