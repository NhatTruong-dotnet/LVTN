import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Chicken({ formData, handleFormDataChange }) {
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
                            { value: 'Gà ác' },
                            { value: 'Gà Brahma' },
                            { value: 'Gà bướm' },
                            { value: 'Gà Đông Tảo' },
                            { value: 'Gà Mặt quỷ' },
                            { value: 'Gà Nòi(Gà chọi)' },
                            { value: 'Gà Quý Phi' },
                            { value: 'Gà Serama' },
                            { value: 'Gà ta' },
                            { value: 'Gà tre' },
                            { value: 'Gà Vảy cá' },
                            { value: 'Gà vảy rồng' },
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
                            { value: 'Gà con(dưới 3 tháng tuổi)' },
                            { value: 'Gà con(từ 3 tháng tuổi)' },
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

export default Chicken
