import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function Another({ formData, handleFormDataChange }) {
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
                        label='Loại xe'
                        value={formData.phuongTienKhacLoaiXe}
                        onChange={e =>
                            handleFormDataChange(
                                'phuongTienKhacLoaiXe',
                                e.target.value
                            )
                        }
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng xe'
                        halfContainer
                        value={formData.phuongTienKhacDongXe}
                        onChange={e =>
                            handleFormDataChange(
                                'phuongTienKhacDongXe',
                                e.target.value
                            )
                        }
                    />

                    <FormInput
                        label='Số chỗ'
                        halfContainer
                        value={formData.phuongTienKhacSoCho}
                        onChange={e =>
                            handleFormDataChange(
                                'phuongTienKhacSoCho',
                                e.target.value
                            )
                        }
                    />

                    <FormInput
                        require
                        label='Năm sản xuất'
                        halfContainer
                        value={formData.nam}
                        onChange={e =>
                            handleFormDataChange('nam', e.target.value)
                        }
                    />

                    <div className={styles.type}>
                        <div className={styles.title}>
                            Nhiên liệu{' '}
                            <span className={styles.required}>*</span>
                        </div>
                        <div
                            onClick={() =>
                                handleFormDataChange(
                                    'phuongTienKhacNhienLieu',
                                    'Xăng'
                                )
                            }
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.phuongTienKhacNhienLieu === 'Xăng',
                            })}
                        >
                            Xăng
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.phuongTienKhacNhienLieu === 'Dầu',
                            })}
                            onClick={() =>
                                handleFormDataChange(
                                    'phuongTienKhacNhienLieu',
                                    'Dầu'
                                )
                            }
                        >
                            Dầu
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.phuongTienKhacNhienLieu ===
                                    'Động cơ Hybrid',
                            })}
                            onClick={() =>
                                handleFormDataChange(
                                    'phuongTienKhacNhienLieu',
                                    'Động cơ Hybrid'
                                )
                            }
                        >
                            Động cơ Hybrid
                        </div>

                        <div className={styles.formMessage}></div>
                    </div>

                    <div className={styles.halfParent}>
                        <FormInput
                            label='Xuất xứ (Không bắt buộc)'
                            halfContainer
                            value={formData.xuatxu}
                            onChange={e =>
                                handleFormDataChange('xuatxu', e.target.value)
                            }
                        />
                        <FormInput
                            label='Màu sắc (Không bắt buộc)'
                            halfContainer
                            value={formData.mauSac}
                            onChange={e =>
                                handleFormDataChange('mauSac', e.target.value)
                            }
                        />
                    </div>

                    {formData.phuongTienDaSuDung && (
                        <div className={styles.halfParent}>
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
                        </div>
                    )}
                </div>
                <div className={styles.type}>
                    <div className={styles.title}>
                        Tình trạng <span className={styles.required}>*</span>
                    </div>
                    <div
                        onClick={() =>
                            handleFormDataChange('phuongTienDaSuDung', true)
                        }
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                formData.phuongTienDaSuDung &&
                                formData.phuongTienDaSuDung !== null,
                        })}
                    >
                        Đã sử dụng
                    </div>
                    <div
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                !formData.phuongTienDaSuDung &&
                                formData.phuongTienDaSuDung !== null,
                        })}
                        onClick={() =>
                            handleFormDataChange('phuongTienDaSuDung', false)
                        }
                    >
                        Xe mới
                    </div>
                    <div className={styles.formMessage}></div>
                </div>

                {formData.phuongTienDaSuDung && (
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
                        onChange={e =>
                            handleFormDataChange('gia', e.target.value)
                        }
                    />
                </div>
            </FormGroup>
        </>
    )
}

export default Another
