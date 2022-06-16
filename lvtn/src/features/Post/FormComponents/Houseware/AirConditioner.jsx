import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function AirConditioner({ formData, handleFormDataChange }) {
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
                            { value: 'Sanyo' },
                            { value: 'Toshiba ' },
                            { value: 'Panasonic' },
                            { value: 'Reetech' },
                            { value: 'Samsung' },
                            { value: 'LG' },
                            { value: 'Sharp' },
                            { value: 'Beko' },
                            { value: 'Teco' },
                            { value: 'Electrolux' },
                            { value: 'Daikin' },
                            { value: 'TCL' },
                            { value: 'Sunhouse' },
                            { value: 'Asanzo' },
                            { value: 'Aqua' },
                            { value: 'Hãng khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Công suất'
                        value={formData.mayLanhCongSuat}
                        onChange={e =>
                            handleFormDataChange(
                                'mayLanhCongSuat',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: '1 HP(ngựa)' },
                            { value: '1.5 HP(ngựa)' },
                            { value: '2 HP(ngựa)' },
                            { value: '>2 HP(ngựa)' },
                            { value: '<10,000 BTU' },
                            { value: '10,000 - 20,000 BTU' },
                            { value: '>20,000 BTU' },
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

export default AirConditioner
