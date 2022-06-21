import styles from './searchcategorypicker.module.css'
import DynamicModal from '../../../../Common/DynamicModal/DynamicModal'
import categories from '../../../CreatePost/categoryData'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import { FaTimes, FaArrowLeft } from 'react-icons/fa'
import { TiThSmall } from 'react-icons/ti'
import { useState } from 'react'
import clsx from 'clsx'
import { useDispatch } from 'react-redux'
import TabContainer from '../../../../Common/TabContainer'

function SearchCategoryPicker({ closeCategoryPicker, setSearchCategory }) {
    const [displayCategory, setDisplayCategory] = useState(categories)
    const dispatch = useDispatch()

    return (
        <TabContainer onClickOutside={closeCategoryPicker}>
            <DynamicModal>
                <div className={styles.cateModalContainer}>
                    <div className={styles.header}>
                        <div className={styles.headerText}>Chọn danh mục</div>
                        <FaArrowLeft
                            className={clsx(styles.icon, styles.left)}
                            onClick={() => {
                                setDisplayCategory(categories)
                            }}
                        />
                        <FaTimes
                            className={clsx(styles.icon, styles.right)}
                            onClick={closeCategoryPicker}
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
                            {displayCategory.map(
                                ({ id, name, Icon, subCategory }) => (
                                    <div
                                        className={styles.categoryItem}
                                        key={id}
                                        onClick={() => {
                                            dispatch({
                                                type: 'getPostWithCategoryId',
                                                categoryId: id,
                                            })
                                            setSearchCategory({
                                                id,
                                                name,
                                            })
                                            if (!subCategory) {
                                                closeCategoryPicker()
                                            } else {
                                                setDisplayCategory(subCategory)
                                            }
                                        }}
                                    >
                                        <div className={styles.nameWrap}>
                                            {Icon && (
                                                <Icon
                                                    className={
                                                        styles.pickerIcon
                                                    }
                                                />
                                            )}
                                            <span className={styles.name}>
                                                {name}
                                            </span>
                                        </div>
                                        <MdOutlineKeyboardArrowRight
                                            className={styles.pickerIcon}
                                        />
                                    </div>
                                )
                            )}
                        </div>
                    </div>
                </div>
            </DynamicModal>
        </TabContainer>
    )
}

export default SearchCategoryPicker
