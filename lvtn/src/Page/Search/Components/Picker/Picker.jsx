import React from 'react'
import styles from './picker.module.css'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import { FaTimes } from 'react-icons/fa'
import { useState } from 'react'
import DynamicModal from '../../../../Common/DynamicModal/DynamicModal'
import clsx from 'clsx'
import MultiRangeSlider from '../../../../Common/MultiRangeSlider/MultiRangeSlider'
import { formatCurrency } from '../../../../Utils/formatCurrency'

function Picker({ handleClickItem, filterItem, selectedValue }) {
    const [showPicker, setShowPicker] = useState(false)
    const openModal = () => setShowPicker(true)
    const closeModal = () => setShowPicker(false)
    const displayText =
        typeof selectedValue === 'string' || typeof selectedValue === 'number'
            ? selectedValue || filterItem.label
            : filterItem.label
    return (
        <>
            <div className={styles.filterItem} onClick={openModal}>
                <span className={styles.filterValue}>
                    {displayText}{' '}
                    {displayText !== filterItem.label && filterItem.unit}
                    <span className={styles.filterIcon}></span>
                </span>
            </div>
            {showPicker && (
                <DynamicModal>
                    {filterItem.type === 'number' ? (
                        <NumberPicker
                            filterItem={filterItem}
                            closeModal={closeModal}
                            handleClickItem={handleClickItem}
                            selectedValue={selectedValue}
                        />
                    ) : (
                        <SelectPicker
                            filterItem={filterItem}
                            closeModal={closeModal}
                            handleClickItem={handleClickItem}
                        />
                    )}
                </DynamicModal>
            )}
        </>
    )
}

function SelectPicker({ filterItem, closeModal, handleClickItem }) {
    return (
        <div className={styles.cateModalContainer}>
            <div className={styles.header}>
                <div className={styles.headerText}>{filterItem.label}</div>

                <FaTimes
                    className={clsx(styles.icon, styles.right)}
                    onClick={closeModal}
                />
            </div>
            <div className={styles.listCategory}>
                <div className={styles.box}>
                    {filterItem.data.map(value => (
                        <div
                            className={styles.categoryItem}
                            key={value}
                            onClick={() => {
                                handleClickItem(filterItem.key, value)
                                closeModal()
                            }}
                        >
                            <div className={styles.nameWrap}>
                                <span className={styles.name}>{value}</span>
                            </div>
                            <MdOutlineKeyboardArrowRight
                                className={styles.pickerIcon}
                            />
                        </div>
                    ))}
                </div>
            </div>
        </div>
    )
}

function NumberPicker({
    filterItem,
    closeModal,
    handleClickItem,
    selectedValue,
}) {
    const [rangeValue, setRangeValue] = useState({
        minValue: selectedValue ? selectedValue.minPrice : filterItem.min,
        maxValue: selectedValue ? selectedValue.maxPrice : filterItem.max,
    })
    console.log(selectedValue)
    console.log(filterItem.key)

    return (
        <div className={styles.cateModalContainer}>
            <div className={styles.header}>
                <div className={styles.headerText}>{filterItem.label}</div>

                <FaTimes
                    className={clsx(styles.icon, styles.right)}
                    onClick={closeModal}
                />
            </div>
            <div className={styles.listCategory}>
                <div className={styles.price}>
                    {filterItem.unit
                        ? `${filterItem.label} từ ${rangeValue.minValue}${filterItem.unit} đến ${rangeValue.maxValue}${filterItem.unit}`
                        : `${filterItem.label} từ ${formatCurrency(
                              rangeValue.minValue
                          )} đến ${formatCurrency(rangeValue.maxValue)}`}
                </div>
                <MultiRangeSlider
                    min={filterItem.min}
                    max={filterItem.max}
                    minValue={
                        selectedValue ? selectedValue.minPrice : filterItem.min
                    }
                    maxValue={
                        selectedValue ? selectedValue.maxPrice : filterItem.max
                    }
                    onChange={({ min, max }) => {
                        setRangeValue({
                            minValue: min,
                            maxValue: max,
                        })
                        handleClickItem(filterItem.key, {
                            minPrice: rangeValue.minValue,
                            maxPrice: rangeValue.maxValue,
                        })
                    }}
                />
            </div>
        </div>
    )
}

export default Picker
