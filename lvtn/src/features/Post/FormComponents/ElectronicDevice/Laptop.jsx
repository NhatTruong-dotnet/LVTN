import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Laptop({ formData, handleFormDataChange }) {
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
                        label='Hãng'
                        value={formData.laptopHang}
                        onChange={e =>
                            handleFormDataChange('laptopHang', e.target.value)
                        }
                        requireData={[
                            { value: 'Apple' },
                            { value: 'Samsung' },
                            { value: 'Asus' },
                            { value: 'LG' },
                            { value: 'Acer' },
                            { value: 'Panasonic' },
                            { value: 'Lenovo' },
                            { value: 'Dell' },
                            { value: 'HP' },
                            { value: 'Microsoft' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng máy'
                        value={formData.laptopDongMay}
                        onChange={e =>
                            handleFormDataChange(
                                'laptopDongMay',
                                e.target.value
                            )
                        }
                    />
                </div>
                <FormInput
                    label='Bộ vi xử lý (Không bắt buộc)'
                    value={formData.laptopBoViXuly}
                    onChange={e =>
                        handleFormDataChange('laptopBoViXuly', e.target.value)
                    }
                    requireData={[
                        { value: 'AMD' },
                        { value: 'Athlon' },
                        { value: 'Intel Atom' },
                        { value: 'Intel Celeron' },
                        { value: 'Intel Core 2 Duo' },
                        { value: 'Intel Core 2 Quad' },
                        { value: 'Intel Core i3' },
                        { value: 'Intel Core i5' },
                        { value: 'Intel Core i7' },
                        { value: 'Intel Core i9' },
                        { value: 'Intel Pentium' },
                        { value: 'Intel Quark' },
                        { value: 'Intel Xeon' },
                        { value: 'Ryzen 3' },
                        { value: 'Ryzen 5' },
                        { value: 'Ryzen 7' },
                        { value: 'Ryzen 9' },
                        { value: 'Khác' },
                    ]}
                />

                <FormInput
                    label='Ram (Không bắt buộc)'
                    value={formData.laptopRam}
                    onChange={e =>
                        handleFormDataChange('laptopRam', e.target.value)
                    }
                    requireData={[
                        { value: '< 1GB' },
                        { value: '1GB' },
                        { value: '2GB' },
                        { value: '4GB' },
                        { value: '6GB' },
                        { value: '8GB' },
                        { value: '16GB' },
                        { value: '32GB' },
                        { value: '>32GB' },
                    ]}
                />
                <FormInput
                    label='Ổ cứng (Không bắt buộc)'
                    value={formData.laptopOcung}
                    onChange={e =>
                        handleFormDataChange('laptopOcung', e.target.value)
                    }
                    requireData={[
                        { value: '< 128GB' },
                        { value: '128GB' },
                        { value: '250GB' },
                        { value: '256GB' },
                        { value: '320GB' },
                        { value: '480GB' },
                        { value: '500GB' },
                        { value: '512GB' },
                        { value: '640GB' },
                        { value: '700GB' },
                        { value: '750GB' },
                        { value: '1TB' },
                        { value: '>1TB' },
                    ]}
                />

                <FormInput
                    require
                    label='Loại ổ cứng '
                    value={formData.laptopHdd}
                    onChange={e =>
                        handleFormDataChange('laptopHdd', e.target.value)
                    }
                    requireData={[{ value: 'HDD' }, { value: 'SSD' }]}
                />

                <FormInput
                    label='Card màn hình (Không bắt buộc)'
                    value={formData.laptopCardManHinh}
                    onChange={e =>
                        handleFormDataChange(
                            'laptopCardManHinh',
                            e.target.value
                        )
                    }
                    requireData={[
                        { value: 'onBoard' },
                        { value: 'AMD' },
                        { value: 'NVIDIA' },
                        { value: 'Khác' },
                    ]}
                />

                <FormInput
                    label='Kích cỡ màn hình (Không bắt buộc)'
                    value={formData.laptopKichCoManHinh}
                    onChange={e =>
                        handleFormDataChange(
                            'laptopKichCoManHinh',
                            e.target.value
                        )
                    }
                    requireData={[
                        { value: '< 9 inch' },
                        { value: '9 - 10.9 inch' },
                        { value: '11 - 12.9 inch' },
                        { value: '13 - 14.9 inch' },
                        { value: '15 - 16.9 inch' },
                        { value: '17 - 18.9 inch' },
                        { value: '19 - 20.9 inch' },
                        { value: '>= 21 inch' },
                    ]}
                />

                <div className={styles.group}>
                    <div className={styles.group}>
                        <FormInput
                            require
                            label='Tình trạng'
                            halfContainer
                            value={formData.tinhTrang}
                            onChange={e =>
                                handleFormDataChange(
                                    'tinhTrang',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Mới' },
                                { value: 'Đã sử dụng (chưa sửa chữa)' },
                                { value: 'Đã sử dụng (đã sửa chữa)' },
                            ]}
                        />
                    </div>

                    <FormInput
                        require
                        label='Bảo hành'
                        halfContainer
                        value={formData.baoHanh}
                        onChange={e =>
                            handleFormDataChange('baoHanh', e.target.value)
                        }
                        requireData={[
                            { value: 'Còn bảo hành' },
                            { value: 'Hết bảo hành' },
                        ]}
                    />

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

export default Laptop
