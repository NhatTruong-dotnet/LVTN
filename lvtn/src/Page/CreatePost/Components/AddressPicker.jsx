import styles from './addresspicker.module.css'
import FormInput from '../../../features/Post/FormComponents/Components/FormInput'
import { useSelector } from 'react-redux'
import { selectLocation } from '../../../features/Post/PostSlice'
import { useState } from 'react'

const convertObjectIntoArray = obj => {
    const result = []
    for (const key in obj) {
        result.push(obj[key])
    }
    return result
}

function AddressPicker({ formData, handleFormDataChange }) {
    const listLocation = useSelector(selectLocation)
    const [district, setDistrict] = useState([])
    const [ward, setWard] = useState([])
    console.log(district)

    const mappingCity = ({
        code,
        name,
        name_with_type,
        handleBackground,
        ...rest
    }) => {
        return (
            <div
                key={code}
                className={styles.item}
                onClick={() => {
                    handleFormDataChange('thanhPho', name_with_type)

                    setDistrict(convertObjectIntoArray(rest['quan-huyen']))
                    handleBackground()
                }}
            >
                {name}
            </div>
        )
    }

    const mappingDistrict = ({
        code,
        name_with_type,
        handleBackground,
        ...rest
    }) => {
        return (
            <div
                key={code}
                className={styles.item}
                onClick={() => {
                    handleFormDataChange('quanHuyen', name_with_type)
                    setWard(convertObjectIntoArray(rest['xa-phuong']))
                    handleBackground()
                }}
            >
                {name_with_type}
            </div>
        )
    }

    const mappingWard = ({ code, name_with_type, handleBackground }) => {
        return (
            <div
                key={code}
                className={styles.item}
                onClick={() => {
                    handleFormDataChange('phuongXa', name_with_type)
                    handleBackground()
                }}
            >
                {name_with_type}
            </div>
        )
    }

    return (
        <div className={styles.group}>
            <FormInput
                label='Chọn thành phố'
                require
                value={formData.thanhPho}
                // onChange={e =>
                //     handleFormDataChange('address', {
                //         ...formData.address,
                //         thanhPho: e.target.value,
                //     })
                // }
                requireData={listLocation}
                functionMapping={mappingCity}
            />

            <FormInput
                require
                label='Chọn quận, huyện, thị xã'
                value={formData.quanHuyen}
                // onChange={e =>
                //     handleFormDataChange('address', {
                //         ...formData.address,
                //         quanHuyen: e.target.value,
                //     })
                // }
                requireData={district}
                functionMapping={mappingDistrict}
            />

            <FormInput
                require
                label='Chọn xã, phường, thị trấn'
                value={formData.phuongXa}
                // onChange={e =>
                //     handleFormDataChange('address', {
                //         ...formData.address,
                //         phuongXa: e.target.value,
                //     })
                // }
                requireData={ward}
                functionMapping={mappingWard}
            />

            <FormInput
                label='Địa chỉ cụ thể'
                value={formData.diaChiCuThe}
                onChange={e =>
                    handleFormDataChange('diaChiCuThe', e.target.value)
                }
            />
        </div>
    )
}

export default AddressPicker
