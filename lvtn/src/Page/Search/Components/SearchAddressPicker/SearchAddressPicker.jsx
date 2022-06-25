import styles from './SearchAddressPicker.module.css'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import { FaTimes } from 'react-icons/fa'
import { useState } from 'react'
import DynamicModal from '../../../../Common/DynamicModal/DynamicModal'
import clsx from 'clsx'
import { selectLocation } from '../../../../features/Post/PostSlice'
import { useSelector, useDispatch } from 'react-redux'
import { useEffect } from 'react'

const convertObjectIntoArray = obj => {
    const result = []
    for (const key in obj) {
        result.push(obj[key])
    }
    return result
}

function SearchAddressPicker({ address, setAddress }) {
    const [showPicker, setShowPicker] = useState(false)
    const listLocation = useSelector(selectLocation)
    const [listAddress, setListAddress] = useState([])
    const dispatch = useDispatch()

    const resetAddress = () => {
        setListAddress(listLocation)
        setAddress({
            key: 'thanhPho',
            thanhPho: '',
            quanHuyen: '',
            phuongXa: '',
            displayText: 'Toàn quốc',
        })
    }
    console.log(address)

    const handleClickItem = (value, rest) => {
        if (address.keySet === 'thanhPho') {
            setAddress({
                ...address,
                thanhPho: value,
                quanHuyen: '',
                phuongXa: '',
                displayText: value,
                keySet: 'quanHuyen',
            })

            setListAddress(convertObjectIntoArray(rest['quan-huyen']))
        } else if (address.keySet === 'quanHuyen') {
            setAddress({
                ...address,
                quanHuyen: value,
                displayText: value,
                keySet: 'phuongXa',
            })

            setListAddress(convertObjectIntoArray(rest['xa-phuong']))
        } else {
            setAddress({
                ...address,
                phuongXa: value,
                displayText: value,

                keySet: 'thanhPho',
            })
            setListAddress(listLocation)
            setShowPicker(false)
        }
    }
    useEffect(() => {
        dispatch({ type: 'loadLocationData' })
    }, [])

    useEffect(() => {
        setListAddress(listLocation)
    }, [listLocation])
    // console.log(listAddress)

    return (
        <>
            <div
                className={styles.filterItem}
                onClick={() => setShowPicker(true)}
            >
                <span className={styles.filterValue}>
                    {address.displayText}
                    <span className={styles.filterIcon}></span>
                </span>
            </div>
            {showPicker && (
                <DynamicModal>
                    <div className={styles.cateModalContainer}>
                        <div className={styles.header}>
                            <div className={styles.headerText}>
                                Chọn danh mục
                            </div>
                            {/* <FaArrowLeft
                            className={clsx(styles.icon, styles.left)}
                            onClick={() => {
                                setDisplayCategory(categories)
                            }}
                        /> */}
                            <FaTimes
                                className={clsx(styles.icon, styles.right)}
                                onClick={() => {
                                    setShowPicker(false)
                                }}
                            />
                        </div>
                        <div className={styles.listCategory}>
                            <div className={styles.box}>
                                <div
                                    className={styles.categoryItem}
                                    onClick={() => {
                                        // setSearchCategory({
                                        //     id: 0,
                                        //     subCategory: -1,
                                        //     name: 'Tất cả danh mục',
                                        // })
                                        // closeCategoryPicker()
                                    }}
                                >
                                    <div
                                        className={styles.nameWrap}
                                        onClick={resetAddress}
                                    >
                                        <span className={styles.name}>
                                            Tất cả{' '}
                                        </span>
                                    </div>
                                    <MdOutlineKeyboardArrowRight
                                        className={styles.pickerIcon}
                                    />
                                </div>
                                {listAddress.map(({ code, name, ...rest }) => (
                                    <div
                                        className={styles.categoryItem}
                                        key={code}
                                        onClick={() =>
                                            handleClickItem(name, rest)
                                        }
                                    >
                                        <div className={styles.nameWrap}>
                                            <span className={styles.name}>
                                                {name}
                                            </span>
                                        </div>
                                        <MdOutlineKeyboardArrowRight
                                            className={styles.pickerIcon}
                                        />
                                    </div>
                                ))}
                            </div>
                        </div>
                    </div>
                </DynamicModal>
            )}
        </>
    )
}

export default SearchAddressPicker
