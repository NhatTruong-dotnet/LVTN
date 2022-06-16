import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Dog({ formData, handleFormDataChange }) {
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
                            { value: 'Chó Alaska' },
                            { value: 'Chó Bắc kinh' },
                            { value: 'Chó becgie' },
                            { value: 'Chó bull' },
                            { value: 'Chó Chihuahua' },
                            { value: 'Chó Chow chow' },
                            { value: 'Chó cỏ' },
                            { value: 'Chó Corgi' },
                            { value: 'Chó Doberman' },
                            { value: 'Chó đốm' },
                            { value: 'Chó gấu bắc hà' },
                            { value: 'Chó golden' },
                            { value: 'Chó Husky' },
                            { value: 'Chó Labrador' },
                            { value: 'Chó lạp xưởng' },
                            { value: 'Chó mông cộc' },
                            { value: 'Chó Nhật' },
                            { value: 'Chó phốc hươu' },
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
                            { value: 'Chó con(dưới 3 tháng tuổi)' },
                            { value: 'Chó nhỏ(dưới 1 năm tuổi)' },
                            { value: 'Chó trưởng thành(hơn 1 tuổi)' },
                            { value: 'Khác(không xác định được)' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Kích cỡ'
                        value={formData.choKichCo}
                        onChange={e =>
                            handleFormDataChange('choKichCo', e.target.value)
                        }
                        requireData={[
                            { value: 'Siêu nhỏ (tiny,teacup)' },
                            { value: 'Nhỏ' },
                            { value: 'Trung bình' },
                            { value: 'Lớn' },
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

export default Dog
