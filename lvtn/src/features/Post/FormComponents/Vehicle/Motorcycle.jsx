import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Motorcycle({ formData, handleFormDataChange }) {
    return (
        <>
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>

            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng'
                        value={formData.hangXe}
                        onChange={e =>
                            handleFormDataChange('hangXe', e.target.value)
                        }
                        requireData={[
                            { value: 'Honda' },
                            { value: 'Suzuki ' },
                            { value: 'Yamaha' },
                            { value: 'Kawasaki' },
                            { value: 'Piaggio' },
                            { value: 'SYM' },
                            { value: 'Kymco' },
                            { value: 'Ducati' },
                            { value: 'Aprilia' },
                            { value: 'BMW' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Màu sắc'
                        halfContainer
                        value={formData.mauSac}
                        onChange={e =>
                            handleFormDataChange('mauSac', e.target.value)
                        }
                    />
                    <FormInput
                        require
                        label='Dòng xe'
                        halfContainer
                        value={formData.xeMayDongXe}
                        onChange={e =>
                            handleFormDataChange('xeMayDongXe', e.target.value)
                        }
                    />

                    <FormInput
                        require
                        label='Năm đăng ký'
                        halfContainer
                        value={formData.nam}
                        onChange={e =>
                            handleFormDataChange('nam', e.target.value)
                        }
                        requireData={[
                            { value: '2022' },
                            { value: '2019' },
                            { value: '2018' },
                            { value: '2017' },
                            { value: '2016' },
                            { value: '2015' },
                            { value: '2014' },
                            { value: '2013' },
                            { value: '2012' },
                            { value: '2011' },
                            { value: '2010' },
                            { value: '2009' },
                            { value: '2008' },
                            { value: '2007' },
                            { value: '2006' },
                            { value: '2005' },
                            { value: '2004' },
                            { value: '2003' },
                            { value: '2002' },
                            { value: '2001' },
                            { value: '2000' },
                            { value: 'Trước năm 2000' },
                        ]}
                    />
                    <FormInput
                        require
                        label='Loại xe'
                        halfContainer
                        value={formData.xeMayLoaiXe}
                        onChange={e =>
                            handleFormDataChange('xeMayLoaiXe', e.target.value)
                        }
                        requireData={[
                            { value: 'Tay ga' },
                            { value: 'Xe số' },
                            { value: 'Tay côn / Moto' },
                        ]}
                    />
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Dung tích xe (Không bắt buộc)'
                            halfContainer
                            value={formData.xeMayDungtich}
                            onChange={e =>
                                handleFormDataChange(
                                    'xeMayDungtich',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Dưới 50cc' },
                                { value: '50cc - 100cc' },
                                { value: '100cc - 175cc' },
                                { value: 'Trên 175cc' },
                                { value: 'Không biết rõ' },
                            ]}
                        />

                        {formData.daSuDung && (
                            <FormInput
                                label='Biển số xe'
                                halfContainer
                                value={formData.bienSoXe}
                                onChange={e =>
                                    handleFormDataChange(
                                        'bienSoXe',
                                        e.target.value
                                    )
                                }
                            />
                        )}
                    </div>
                </div>
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
                    Xe mới
                </div>
                <div className={styles.formMessage}></div>
            </div>

            {formData.daSuDung && (
                <div className={styles.group}>
                    <FormInput
                        require
                        type='number'
                        unit='km'
                        label='Số km đã đi'
                        value={formData.soKmDaDi}
                        onChange={e =>
                            handleFormDataChange('soKmDaDi', e.target.value)
                        }
                    />
                </div>
            )}
            <div className={styles.group}>
                <FormInput
                    require
                    type='number'
                    unit='đ'
                    label='Giá'
                    value={formData.gia}
                    onChange={e => handleFormDataChange('gia', e.target.value)}
                />
            </div>
        </>
    )
}

export default Motorcycle
