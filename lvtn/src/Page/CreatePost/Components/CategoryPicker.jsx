import DynamicModal from '../../../Common/DynamicModal/DynamicModal'
import { useState } from 'react'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import data from '../categoryData'
import styles from './categorypicker.module.css'
import TabContainer from '../../../Common/TabContainer'

function CategoryPicker({
    closeCategoryPicker,
    selectedCategory,
    setSelectedCategory,
}) {
    const [categories, setCategories] = useState(data)

    const chooseParentCategory = (id, name, subCategory, Component) => {
        // choose parent category and has subCategory
        if (subCategory) {
            setSelectedCategory({
                ...selectedCategory,
                category: { id, name, Component: Component },
            })
            setCategories(subCategory)
        }
        // choose parent category and no subCategory
        else if (subCategory === null) {
            setSelectedCategory({
                ...selectedCategory,
                category: { id, name, Component },
                subCategory: null,
            })
            closeCategoryPicker()
        }
        // Choose subcategory
        else {
            setSelectedCategory({
                ...selectedCategory,
                subCategory: { id, name },
            })
            closeCategoryPicker()
        }
    }
    return (
        <DynamicModal>
            <div className={styles.cateModalContainer}>
                <div className={styles.header}>
                    <div className={styles.headerText}>
                        Chọn danh mục đăng tin
                    </div>
                </div>
                <div className={styles.listCategory}>
                    <div className={styles.box}>
                        {categories.map(
                            ({ id, name, Icon, subCategory, Component }) => (
                                <div
                                    className={styles.categoryItem}
                                    key={id}
                                    onClick={() =>
                                        chooseParentCategory(
                                            id,
                                            name,
                                            subCategory,
                                            Component
                                        )
                                    }
                                >
                                    <div className={styles.nameWrap}>
                                        {Icon && (
                                            <Icon
                                                className={styles.pickerIcon}
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
    )
}

export default CategoryPicker
