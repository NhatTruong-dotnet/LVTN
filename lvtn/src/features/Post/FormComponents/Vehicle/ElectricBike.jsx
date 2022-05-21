import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function ElectricBike({ formData, handleFormDataChange }) {
    return (
        <>
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Chọn thành phố'
                            require
                            halfContainer
                            value={formData.address.thanhPho}
                            onChange={e =>
                                handleFormDataChange('address', {
                                    ...formData.address,
                                    thanhPho: e.target.value,
                                })
                            }
                        />

                        <FormInput
                            require
                            label='Chọn quận, huyện, thị xã'
                            halfContainer
                            value={formData.address.quanHuyen}
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
                            value={formData.address.phuongXa}
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
                            value={formData.address.tenDuong}
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
                            value={formData.address.soNha}
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

            <FormGroup title='Thông tin chi tiết'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Hãng xe'
                        value={formData.hangXe}
                        onChange={e =>
                            handleFormDataChange('hangXe', e.target.value)
                        }
                        requireData={[
                            { value: 'Aima' },
                            { value: 'Anbico' },
                            { value: 'Asama' },
                            { value: 'BMX' },
                            { value: 'Bridgestone' },
                            { value: 'Detech' },
                            { value: 'Dibao' },
                            { value: 'DKBike' },
                            { value: 'Giant' },
                            { value: 'Hitasa' },
                            { value: 'HKBIKE' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Loại xe'
                        halfContainer
                        value={formData.xeDienLoaiXe}
                        onChange={e =>
                            handleFormDataChange('xeDienLoaiXe', e.target.value)
                        }
                        requireData={[
                            { value: 'Xe đạp điện' },
                            { value: 'Xe máy điện' },
                            { value: 'Xe điện khác' },
                        ]}
                    />

                    <FormInput
                        require
                        label='Động cơ'
                        halfContainer
                        value={formData.xeDienDongCo}
                        onChange={e =>
                            handleFormDataChange('xeDienDongCo', e.target.value)
                        }
                        requireData={[
                            { value: '<200W' },
                            { value: '200 - 250W' },
                            { value: '251 - 350W' },
                            { value: '351 - 500W' },
                            { value: '501 - 1000W' },
                            { value: '>100W' },
                        ]}
                    />
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Xuất xứ (Không bắt buộc)'
                            halfContainer
                            value={formData.xuatxu}
                            onChange={e =>
                                handleFormDataChange('xuatxu', e.target.value)
                            }
                            requireData={[
                                { value: 'Việt Nam' },
                                { value: 'Ấn Độ' },
                                { value: 'Thái Lan' },
                                { value: 'Hàn Quốc' },
                                { value: 'Nhật Bản' },
                                { value: 'Trung Quốc' },
                                { value: 'Mỹ' },
                                { value: 'Đức' },
                                { value: 'Đài Loan' },
                            ]}
                        />

                        <FormInput
                            label='Màu sắc (Không bắt buộc)'
                            halfContainer
                            value={formData.mauSac}
                            onChange={e =>
                                handleFormDataChange('mauSac', e.target.value)
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
                    </div>
                    <div className={styles.type}>
                        <div className={styles.title}>
                            Tình trạng{' '}
                            <span className={styles.required}>*</span>
                        </div>
                        <div
                            onClick={() =>
                                handleFormDataChange('xeDienDaSuDung', true)
                            }
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.xeDienDaSuDung &&
                                    formData.xeDienDaSuDung !== null,
                            })}
                        >
                            Đã sử dụng
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    !formData.xeDienDaSuDung &&
                                    formData.xeDienDaSuDung !== null,
                            })}
                            onClick={() =>
                                handleFormDataChange('xeDienDaSuDung', false)
                            }
                        >
                            Xe mới
                        </div>
                        <div className={styles.formMessage}></div>
                    </div>
                    <FormInput
                        require
                        label='Bảo hành(Không bắt buộc)'
                        value={formData.xeDienBaoHanh}
                        onChange={e =>
                            handleFormDataChange(
                                'xeDienBaoHanh',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Hết bảo hành' },
                            { value: '< 3 tháng' },
                            { value: '3 tháng' },
                            { value: '6 tháng' },
                            { value: '12 tháng' },
                            { value: '18 tháng' },
                            { value: '24 tháng' },
                            { value: '>24 tháng' },
                        ]}
                    />

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
            </FormGroup>
        </>
    )
}

export default ElectricBike
