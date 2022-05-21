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
                        requireData={[
                            { value: 'Hino' },
                            { value: 'Chiến thắng ' },
                            { value: 'Cửu Long' },
                            { value: 'Daewoo' },
                            { value: 'Dongben' },
                            { value: 'Dongfeng' },
                            { value: 'FAW' },
                            { value: 'Forcia' },
                            { value: 'Fusin' },
                            { value: 'Fuso' },
                            { value: 'Hoa mai' },
                            { value: 'Huyndai' },
                        ]}
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
                        requireData={[
                            { value: '< 1 tấn' },
                            { value: '2 tấn' },
                            { value: '3 tấn' },
                            { value: '4 tấn' },
                            { value: '5 tấn' },
                            { value: '6 tấn' },
                            { value: '7 tấn' },
                            { value: '8 tấn' },
                            { value: '9 tấn' },
                            { value: '10 tấn' },
                            { value: '11 tấn' },
                            { value: '12 tấn' },
                            { value: '13 tấn' },
                            { value: '14 tấn' },
                            { value: '15 tấn' },
                            { value: '16 tấn' },
                            { value: '17 tấn' },
                            { value: '18 tấn' },
                            { value: '> 18 tấn' },
                        ]}
                    />

                    <FormInput
                        require
                        label='Năm sản xuất'
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
