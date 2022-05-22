import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function MobilePhone({ formData, handleFormDataChange }) {
    return (
        <>
            {/* Địa chỉ và hình ảnh */}
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Chọn thành phố'
                            require
                            halfContainer
                            value={formData.address?.thanhPho}
                            onChange={e => {
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    thanhPho: e.target.value,
                                })
                            }}
                        />

                        <FormInput
                            require
                            label='Chọn quận, huyện, thị xã'
                            halfContainer
                            value={formData.address?.quanHuyen}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    quanHuyen: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Chọn xã, phường, thị trấn'
                            halfContainer
                            value={formData.address?.phuongXa}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    phuongXa: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Tên đường'
                            halfContainer
                            value={formData.address?.tenDuong}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    tenDuong: e.target.value,
                                })
                            }
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Số nhà'
                            halfContainer
                            value={formData.address?.soNha}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    soNha: e.target.value,
                                })
                            }
                        />
                    </div>
                </div>
            </FormGroup>

            {/* Thông tin chi tiết */}
            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng'
                        value={formData.dienThoaiHang}
                        onChange={e =>
                            handleFormDataChange(
                                'dienThoaiHang',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Apple' },
                            { value: 'Samsung' },
                            { value: 'Oppo' },
                            { value: 'Xiaomi' },
                            { value: 'Vsmart' },
                            { value: 'Nokia' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng máy'
                        value={formData.dienThoaiDong}
                        onChange={e =>
                            handleFormDataChange(
                                'dienThoaiDong',
                                e.target.value
                            )
                        }
                    />
                </div>
                <div className={styles.type}>
                    <div className={styles.title}>
                        Phiên bản <span className={styles.required}>*</span>
                    </div>
                    <div
                        onClick={() =>
                            handleFormDataChange('phienBan', 'Quốc tế')
                        }
                        className={clsx(styles.typeItem, {
                            [styles.active]: formData.phienBan === 'Quốc tế',
                        })}
                    >
                        Quốc tế
                    </div>
                    <div
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                formData.phienBan === 'Khóa mạng (lock)',
                        })}
                        onClick={() =>
                            handleFormDataChange('phienBan', 'Khóa mạng (lock)')
                        }
                    >
                        Khóa mạng (lock)
                    </div>
                    <div className={styles.formMessage}></div>
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Tình trạng'
                        halfContainer
                        value={formData.tinhTrang}
                        onChange={e =>
                            handleFormDataChange('tinhTrang', e.target.value)
                        }
                        requireData={[
                            { value: 'Mới' },
                            { value: 'Đã sử dụng (chưa sửa chữa)' },
                            { value: 'Đã sử dụng (đã sửa chữa)' },
                        ]}
                    />

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
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Màu sắc'
                            halfContainer
                            value={formData.dienThoaiMauSac}
                            onChange={e =>
                                handleFormDataChange(
                                    'dienThoaiMauSac',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Trắng' },
                                { value: 'Đen' },
                                { value: 'Bạc' },
                                { value: 'Cam' },
                                { value: 'Đỏ' },
                                { value: 'Xanh dương' },
                                { value: 'Vàng' },
                                { value: 'Xanh lá' },
                                { value: 'Hồng' },
                                { value: 'Xám' },
                                { value: 'Nâu' },
                            ]}
                        />

                        <FormInput
                            label='Dung lượng'
                            halfContainer
                            value={formData.dienThoaiDungLuong}
                            onChange={e =>
                                handleFormDataChange(
                                    'dienThoaiDungLuong',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: '< 8GB' },
                                { value: '8GB' },
                                { value: '16GB' },
                                { value: '32GB' },
                                { value: '64GB' },
                                { value: '128GB' },
                                { value: '256GB' },
                                { value: '> 256GB' },
                            ]}
                        />
                    </div>
                    <div>
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
                </div>
            </FormGroup>
        </>
    )
}

export default MobilePhone
