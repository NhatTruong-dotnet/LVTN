import styles from '../RealEstate/index.module.css'
import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import clsx from 'clsx'
import AddressPicker from '../../../../Page/CreatePost/Components/AddressPicker'

function Job({ formData, handleFormDataChange }) {
    console.log(formData)
    return (
        <>
            {/* Địa chỉ và hình ảnh */}
            <FormGroup title='Địa chỉ và Hình ảnh'>
                <AddressPicker
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            </FormGroup>
            <div className={styles.type}>
                <div className={styles.title}>
                    Bạn là
                    <span className={styles.required}>*</span>
                </div>
                <div
                    onClick={() => handleFormDataChange('caNhan', true)}
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            formData.caNhan && formData.caNhan !== null,
                    })}
                >
                    Cá nhân
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            !formData.caNhan && formData.caNhan !== null,
                    })}
                    onClick={() => handleFormDataChange('caNhan', false)}
                >
                    Công ty
                </div>
                <div className={styles.formMessage}></div>
            </div>
            {/* Thông tin nhà tuyển dụng */}
            <FormGroup title='Thông tin nhà tuyển dụng'>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Tên hộ kinh doanh'
                        value={formData.tenHoKinhDoanh}
                        onChange={e =>
                            handleFormDataChange(
                                'tenHoKinhDoanh',
                                e.target.value
                            )
                        }
                    />
                </div>
            </FormGroup>

            <FormGroup title={'Nội dung tin đăng'}>
                <div className={styles.group}>
                    <FormInput
                        require
                        label='Số lượng tuyển dụng'
                        type='number'
                        value={formData.soLuongTuyenDung}
                        onChange={e =>
                            handleFormDataChange(
                                'soLuongTuyenDung',
                                e.target.value
                            )
                        }
                    />
                </div>
                <FormInput
                    require
                    label='Ngành nghề'
                    value={formData.nganhNghe}
                    onChange={e =>
                        handleFormDataChange('nganhNghe', e.target.value)
                    }
                    requireData={[
                        { value: 'Bán hàng (Online/cửa hàng)' },
                        { value: 'Nhân viên kinh doanh' },
                        { value: 'Bất động sản' },
                        { value: 'Bảo vệ/an ninh/vệ sĩ' },
                        { value: 'Lao động phổ thông' },
                        { value: 'Công nhân' },
                        { value: 'Công việc khác' },
                        { value: 'Giúp việc/tạp vụ' },
                        { value: 'Nhân viên Spa/Thẩm mỹ viện/Làm tóc/Nail' },
                        { value: 'Chăm sóc khách hàng' },
                        { value: 'FG/FB/Lễ tân' },
                        { value: 'Nhân viên pha chế/Đóng gói thực phẩm' },
                        { value: 'Nhân viên nhà hàng/khách sạn' },
                        { value: 'Đầu bếp/Pha chế' },
                        { value: 'Hành chính/Thư ký/Trợ lý' },
                        { value: 'Tài chính/Kế toán/Kiểm toán' },
                        { value: 'Thợ dệt/May/Da giày' },
                        { value: 'Thợ sửa chữa các loại' },
                        { value: 'Thợ xây/Thợ hồ' },
                        { value: 'Thợ điện/Điện tử/Điện lạnh' },
                        { value: 'Tài xế/Giao nhận xe ô tô' },
                        { value: 'Tài xế/Giao nhận xe máy' },
                        { value: 'Khác' },
                    ]}
                />

                <FormInput
                    require
                    label='Loại công việc'
                    value={formData.loaiCongViec}
                    onChange={e =>
                        handleFormDataChange('loaiCongViec', e.target.value)
                    }
                    requireData={[
                        { value: 'Toàn thời gian' },
                        { value: 'Bán thời gian' },
                        { value: 'Thời vụ' },
                        { value: 'Theo sản phẩm/làm tại nhà' },
                        { value: 'Làm theo ca' },
                        { value: 'Thực tập/ Dự án' },
                        { value: 'Khác' },
                    ]}
                />
                <FormInput
                    require
                    label='Hình thức trả lương'
                    value={formData.hinhThucTraLuong}
                    onChange={e =>
                        handleFormDataChange('hinhThucTraLuong', e.target.value)
                    }
                    requireData={[
                        { value: 'Theo giờ' },
                        { value: 'Theo ngày' },
                        { value: 'Theo tháng' },
                        { value: 'Lương khoán' },
                    ]}
                />

                <div className={styles.halfParent}>
                    <FormInput
                        require
                        label='Lương tối thiểu'
                        value={formData.luongToiThieu}
                        type='number'
                        unit='đ'
                        onChange={e =>
                            handleFormDataChange(
                                'luongToiThieu',
                                e.target.value
                            )
                        }
                    />

                    <FormInput
                        require
                        label='Lương tối đa'
                        value={formData.luongToiDa}
                        type='number'
                        unit='đ'
                        onChange={e =>
                            handleFormDataChange('luongToiDa', e.target.value)
                        }
                    />
                </div>
            </FormGroup>
            <FormGroup title={'Thông tin thêm'}>
                <div className={styles.group}>
                    <div className={styles.halfParent}>
                        <FormInput
                            require
                            label='Độ tuổi tối thiểu'
                            type='number'
                            value={formData.doTuoiToiThieu}
                            onChange={e =>
                                handleFormDataChange(
                                    'doTuoiToiThieu',
                                    e.target.value
                                )
                            }
                        />

                        <FormInput
                            require
                            label='Độ tuổi tối đa'
                            type='number'
                            value={formData.doTuoiToiDa}
                            onChange={e =>
                                handleFormDataChange(
                                    'doTuoiToiDa',
                                    e.target.value
                                )
                            }
                        />
                    </div>
                </div>

                <FormInput
                    label='Học vấn tối thiểu (Không bắt buộc)'
                    value={formData.hocVanToiThieu}
                    onChange={e =>
                        handleFormDataChange('hocVanToiThieu', e.target.value)
                    }
                    requireData={[
                        { value: 'Không yêu cầu' },
                        { value: 'Cấp 1' },
                        { value: 'Cấp 2' },
                        { value: 'Cấp 3' },
                        { value: 'Trung cấp/Nghề' },
                        { value: 'Cao đẳng' },
                        { value: 'Đại học' },
                        { value: 'Khác' },
                    ]}
                />
                <FormInput
                    label='Năm kinh nghiệm (Không bắt buộc)'
                    value={formData.kinhNghiem}
                    onChange={e =>
                        handleFormDataChange('kinhNghiem', e.target.value)
                    }
                    requireData={[
                        { value: 'Không yêu cầu' },
                        { value: '<1 năm' },
                        { value: '1-2 năm' },
                        { value: '3-5 năm' },
                        { value: '6-10 năm' },
                        { value: '>10 năm' },
                    ]}
                />
                <FormInput
                    label='Chứng chỉ / kỹ năng'
                    value={formData.chungChi}
                    onChange={e =>
                        handleFormDataChange('chungChi', e.target.value)
                    }
                />
                <FormInput
                    label='Các quyền lợi khác'
                    value={formData.quyenLoi}
                    onChange={e =>
                        handleFormDataChange('quyenLoi', e.target.value)
                    }
                />
            </FormGroup>
        </>
    )
}

export default Job
