import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Car({ formData, handleFormDataChange }) {
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
                            { value: 'Toyota' },
                            { value: 'Vinfast ' },
                            { value: 'Huyndai' },
                            { value: 'Ford' },
                            { value: 'Honda' },
                            { value: 'Mitsubishi' },
                            { value: 'Kia' },
                            { value: 'Mazda' },
                            { value: 'Acura' },
                            { value: 'Alfa Romeo' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Dòng xe'
                        halfContainer
                        value={formData.otoDongXe}
                        onChange={e =>
                            handleFormDataChange('otoDongXe', e.target.value)
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
                            label='Kiểu dáng (Không bắt buộc)'
                            halfContainer
                            value={formData.otoKieuDang}
                            onChange={e =>
                                handleFormDataChange(
                                    'otoKieuDang',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Sedan' },
                                { value: 'SUV / Cross over' },
                                { value: 'Hatchback' },
                                { value: 'Pick up (bán tải)' },
                                { value: 'Minivan (MPV)' },
                                { value: 'Van' },
                                { value: 'Couple (2 cửa)' },
                                { value: 'Mui trần' },
                                { value: 'Kiểu dáng khác' },
                            ]}
                        />
                    </div>
                    <div className={styles.halfParent}>
                        <FormInput
                            label='Số chỗ (Không bắt buộc)'
                            halfContainer
                            value={formData.otoSocho}
                            onChange={e =>
                                handleFormDataChange('otoSocho', e.target.value)
                            }
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
                    Hộp số <span className={styles.required}>*</span>
                </div>
                <div
                    onClick={() =>
                        handleFormDataChange('otoHopSo', 'Số tự động')
                    }
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoHopSo === 'Số tự động',
                    })}
                >
                    Số tự động
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoHopSo === 'Số sàn',
                    })}
                    onClick={() => handleFormDataChange('otoHopSo', 'Số sàn')}
                >
                    Số sàn
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoHopSo === 'Bán tự động',
                    })}
                    onClick={() => handleFormDataChange('otoHopSo', false)}
                >
                    Bán tự động
                </div>
                <div className={styles.formMessage}></div>
            </div>

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

            <div className={styles.type}>
                <div className={styles.title}>
                    Nhiên liệu <span className={styles.required}>*</span>
                </div>
                <div
                    onClick={() => handleFormDataChange('otoNhieuLieu', 'Xăng')}
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoNhieuLieu === 'Xăng',
                    })}
                >
                    Xăng
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoNhieuLieu === 'Dầu',
                    })}
                    onClick={() => handleFormDataChange('otoNhieuLieu', 'Dầu')}
                >
                    Dầu
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            formData.otoNhieuLieu === 'Động cơ Hybrid',
                    })}
                    onClick={() =>
                        handleFormDataChange('otoNhieuLieu', 'Động cơ Hybrid')
                    }
                >
                    Động cơ Hybrid
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]: formData.otoNhieuLieu === 'Điện',
                    })}
                    onClick={() => handleFormDataChange('otoNhieuLieu', 'Điện')}
                >
                    Điện
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
            {/* <FormGroup title='Giá'>
            </FormGroup> */}
        </>
    )
}

export default Car
