import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function WashingMachine({ formData, handleFormDataChange }) {
    return (
        <>
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>
            <div className={styles.type}>
                <div className={styles.title}>
                    Tình trạng <span className={styles.required}>*</span>
                </div>
                <div
                    onClick={() => handleFormDataChange('daSuDung', true)}
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            formData.daSuDung && formData.daSuDung !== null,
                    })}
                >
                    Đã sử dụng
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            !formData.daSuDung && formData.daSuDung !== null,
                    })}
                    onClick={() => handleFormDataChange('daSuDung', false)}
                >
                    mới
                </div>
                <div className={styles.formMessage}></div>
            </div>
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng'
                        value={formData.hang}
                        onChange={e =>
                            handleFormDataChange('hang', e.target.value)
                        }
                        requireData={[
                            { value: 'Toshiba ' },
                            { value: 'Samsung' },
                            { value: 'Panasonic' },
                            { value: 'Electrolux' },
                            { value: 'LG' },
                            { value: 'Sharp' },
                            { value: 'Aqua' },
                            { value: 'Beko' },
                            { value: 'Hãng khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Cửa máy giặt'
                        value={formData.mayGiatCuaMayGiat}
                        onChange={e =>
                            handleFormDataChange(
                                'mayGiatCuaMayGiat',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Cửa trước (lồng ngang)' },
                            { value: 'Cửa trên (lồng đứng) ' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Khối lượng giặt'
                        value={formData.mayGiatKhoiLuongGiat}
                        onChange={e =>
                            handleFormDataChange(
                                'mayGiatKhoiLuongGiat',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: '<7 kg' },
                            { value: '7 - 7.9 kg' },
                            { value: '8 - 8.9 kg' },
                            { value: '9 - 9.9 kg' },
                            { value: '>10 kg' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <div className={styles.group}>
                        <input
                            type='checkbox'
                            id='isFree'
                            checked={formData.mienPhi}
                            onChange={e =>
                                handleFormDataChange(
                                    'mienPhi',
                                    e.target.checked
                                )
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
                </div>
            </FormGroup>
        </>
    )
}

export default WashingMachine
