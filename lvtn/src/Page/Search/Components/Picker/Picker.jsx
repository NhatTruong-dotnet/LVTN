import React from 'react'
import styles from './picker.module.css'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import { TiThSmall } from 'react-icons/ti'
import { FaArrowLeft, FaTimes } from 'react-icons/fa'

function Picker({
    title,
    handleBack,
    handleClose,
    listPicker,
    handleClickItem,
}) {
    return (
        <DynamicModal>
            <div className={styles.cateModalContainer}>
                <div className={styles.header}>
                    <div className={styles.headerText}>{title}</div>
                    <FaArrowLeft
                        className={clsx(styles.icon, styles.left)}
                        onClick={() => {
                            // setDisplayCategory(categories)
                            handleBack()
                        }}
                    />
                    <FaTimes
                        className={clsx(styles.icon, styles.right)}
                        onClick={handleClose}
                    />
                </div>
                <div className={styles.listCategory}>
                    <div className={styles.box}>
                        <div
                            className={styles.categoryItem}
                            onClick={() => {
                                setSearchCategory({
                                    id: 0,
                                    name: 'Tất cả danh mục',
                                })
                                closeCategoryPicker()
                            }}
                        >
                            <div className={styles.nameWrap}>
                                <TiThSmall className={styles.pickerIcon} />

                                <span className={styles.name}>
                                    Tất cả danh mục
                                </span>
                            </div>
                            <MdOutlineKeyboardArrowRight
                                className={styles.pickerIcon}
                            />
                        </div>
                        {listPicker.map(({ id, name, Icon, subCategory }) => (
                            <div
                                className={styles.categoryItem}
                                key={id}
                                onClick={() => {
                                    // dispatch({
                                    //     type: 'getPostWithCategoryId',
                                    //     categoryId: id,
                                    // })
                                    // setSearchCategory({
                                    //     id,
                                    //     name,
                                    // })
                                    // if (!subCategory) {
                                    //     closeCategoryPicker()
                                    // } else {
                                    //     setDisplayCategory(subCategory)
                                    // }
                                    handleClickItem()
                                }}
                            >
                                <div className={styles.nameWrap}>
                                    {Icon && (
                                        <Icon className={styles.pickerIcon} />
                                    )}
                                    <span className={styles.name}>{name}</span>
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
    )
}

export default Picker
