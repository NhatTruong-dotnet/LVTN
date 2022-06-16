import styles from '../RealEstate/index.module.css'
import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function MomAndBaby({ formData, handleFormDataChange }) {
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
                        label='Loại sản phẩm'
                        value={formData.loaiSanPham}
                        onChange={e =>
                            handleFormDataChange('loaiSanPham', e.target.value)
                        }
                        requireData={[
                            { value: 'Cho mẹ' },
                            { value: 'Cho bé' },
                            { value: 'Cả hai' },
                        ]}
                    />
                </div>
            </FormGroup>
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
        </>
    )
}

export default MomAndBaby
