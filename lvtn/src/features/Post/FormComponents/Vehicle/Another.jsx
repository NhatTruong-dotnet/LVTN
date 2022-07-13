import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import styles from '../RealEstate/index.module.css'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Another({ formData, handleFormDataChange }) {
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
                        label='Loại xe'
                        value={formData.phuongTienKhacLoaiXe}
                        onChange={e =>
                            handleFormDataChange(
                                'phuongTienKhacLoaiXe',
                                e.target.value
                            )
                        }
                        requireData={[
                            { value: 'Xe chuyên dụng' },
                            { value: 'Xe khách, xe buýt' },
                            { value: 'Khác' },
                        ]}
                    />
                </div>
                <div className={styles.group}>
                    {formData.phuongTienKhacLoaiXe === 'Xe chuyên dụng' ? (
                        <FormInput
                            require
                            label='Loại xe chuyên dụng'
                            halfContainer
                            value={formData.phuongTienKhacDongXe}
                            onChange={e =>
                                handleFormDataChange(
                                    'phuongTienKhacDongXe',
                                    e.target.value
                                )
                            }
                            requireData={[
                                { value: 'Xe ba gác / Xe lôi' },
                                { value: 'Xe bồn' },
                                { value: 'Xe chở rác' },
                                { value: 'Xe công nông' },
                                { value: 'Xe đầu kéo' },
                                { value: 'Xe đông lạnh' },
                                { value: 'Xe hút chất thải' },
                                { value: 'Xe Lam' },
                                { value: 'Xe Lu' },
                                { value: 'Xe máy cày' },
                                { value: 'Xe nâng' },
                                { value: 'Xe phun nước' },
                                { value: 'Xe xúc' },
                                { value: 'khác' },
                            ]}
                        />
                    ) : (
                        ''
                    )}

                    {formData.phuongTienKhacLoaiXe === 'Xe khách, xe buýt' ? (
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
                            requireData={[
                                { value: '7 chỗ' },
                                { value: '9 chỗ' },
                                { value: '10 chỗ' },
                                { value: '16 chỗ' },
                                { value: '29 chỗ' },
                                { value: '36 chỗ' },
                                { value: '45 chỗ' },
                                { value: 'Khác' },
                            ]}
                        />
                    ) : (
                        ''
                    )}

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
