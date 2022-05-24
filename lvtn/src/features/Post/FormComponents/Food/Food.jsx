import styles from '../RealEstate/index.module.css'
import FormInput from '../Components/FormInput'
import FormGroup from '../Components/FormGroup'
import clsx from 'clsx'

function Food({ formData, handleFormDataChange }) {
    console.log('running')
    console.log(formData)
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
                        label='Loại thực phẩm'
                        value={formData.loaiThucPham}
                        onChange={e =>
                            handleFormDataChange('loaiThucPham', e.target.value)
                        }
                        requireData={[
                            { value: 'Bánh kẹo, đồ ăn vặt' },
                            { value: 'Bơ' },
                            { value: 'Sữa' },
                            { value: 'Trứng' },
                            { value: 'Kem, sữa chua' },
                            { value: 'Sản phẩm từ bơ sữa' },
                            {
                                value: 'Lương thực (gạo, mì, nui, bánh tráng,...)',
                            },
                            { value: 'Các loại hạt, ngũ cốc, bột' },
                            { value: 'Gia vị' },
                            { value: 'Đồ khô' },
                            { value: 'Các loại mắm' },
                            { value: 'Đồ uống, giải khát' },
                            { value: 'Cà phê' },
                            { value: 'Trà' },
                            { value: 'Trà sữa' },
                            { value: 'Trái cây' },
                            { value: 'rau củ quả' },
                            { value: 'Thịt bò' },
                            { value: 'Thịt gà' },
                            { value: 'Thịt heo' },
                            { value: 'Thịt vịt' },
                            { value: 'Thịt khác' },
                            { value: 'Chả' },
                            { value: 'Đồ viên, xúc xích' },
                            { value: 'Bánh mì, bánh hấp các loại' },
                            { value: 'Món nấu sẵn' },
                            { value: 'thực phẩm bổ dưỡng' },
                            { value: 'Cá' },
                            { value: 'tôm' },
                            { value: 'Mực' },
                            { value: 'Cua ghẹ' },
                            { value: 'Nghêu, sò, các loại ốc' },
                            { value: 'Thực phẩm khác' },
                        ]}
                    />
                </div>
            </FormGroup>
            <div className={styles.group}>
                <input
                    type='checkbox'
                    id='isFree'
                    checked={formData.mienPhi}
                    onChange={e =>
                        handleFormDataChange('mienPhi', e.target.checked)
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
        </>
    )
}

export default Food
