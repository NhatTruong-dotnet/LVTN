import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'

function Truck({ formData, handleFormDataChange }) {
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
                        label='Hãng'
                        value={formData.hangXe}
                        onChange={e =>
                            handleFormDataChange('hangXe', e.target.value)
                        }
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Trọng tải'
                        unit='tấn'
                        halfContainer
                        value={formData.xeTaiTrongTai}
                        onChange={e =>
                            handleFormDataChange(
                                'xeTaiTrongTai',
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
                                handleFormDataChange('xeTaiNhieuLieu', 'Xăng')
                            }
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.xeTaiNhieuLieu === 'Xăng',
                            })}
                        >
                            Xăng
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.xeTaiNhieuLieu === 'Dầu',
                            })}
                            onClick={() =>
                                handleFormDataChange('xeTaiNhieuLieu', 'Dầu')
                            }
                        >
                            Dầu
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.xeTaiNhieuLieu ===
                                    'Động cơ Hybrid',
                            })}
                            onClick={() =>
                                handleFormDataChange(
                                    'xeTaiNhieuLieu',
                                    'Động cơ Hybrid'
                                )
                            }
                        >
                            Động cơ Hybrid
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.xeTaiNhieuLieu === 'Điện',
                            })}
                            onClick={() =>
                                handleFormDataChange('xeTaiNhieuLieu', 'Điện')
                            }
                        >
                            Điện
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

                    {formData.daSuDung && (
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

export default Truck
