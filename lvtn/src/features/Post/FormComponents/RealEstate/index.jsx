import styles from './index.module.css'
import Apartment from './Apartment'
import House from './House'
import Land from './Land'
import Office from './Office'
import Motel from './Motel'
import { useEffect, useState } from 'react'
import clsx from 'clsx'

const subCategories = [
    {
        id: 13,
        Component: ({ formData, handleFormDataChange }) => (
            <Apartment
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 14,
        Component: ({ formData, handleFormDataChange }) => (
            <House
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    { id: 15, Component: () => <Land /> },
    { id: 16, Component: () => <Office /> },
    { id: 17, Component: () => <Motel /> },
]

function RealEstate({ subCategoryId, formData, handleFormDataChange }) {
    const [currentSubCategory, setCurrentSubCategory] = useState(null)
    console.log(formData)

    useEffect(() => {
        const element = subCategories.find(({ id }) => id === subCategoryId)
        setCurrentSubCategory(element)
    }, [subCategoryId])

    return (
        <div>
            <div className={styles.type}>
                <div className={styles.title}>
                    Danh mục bất động sản{' '}
                    <span className={styles.required}>*</span>
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            formData.isSell && formData.isSell !== null,
                    })}
                    onClick={() => handleFormDataChange('isSell', true)}
                >
                    Cần bán
                </div>
                <div
                    className={clsx(styles.typeItem, {
                        [styles.active]:
                            !formData.isSell && formData.isSell !== null,
                    })}
                    onClick={() => handleFormDataChange('isSell', false)}
                >
                    Cho thuê
                </div>
            </div>
            {formData.isSell && (
                <div className={styles.type}>
                    <div className={styles.title}>
                        Tình trạng bất động sản{' '}
                        <span className={styles.required}>*</span>
                    </div>
                    <div
                        className={styles.typeItem}
                        onClick={() => handleFormDataChange('isHandOver', true)}
                    >
                        Đã bàn giao
                    </div>
                    <div
                        className={styles.typeItem}
                        onClick={() =>
                            handleFormDataChange('isHandOver', false)
                        }
                    >
                        Chưa bàn giao
                    </div>
                    <div className={styles.formMessage}>hello</div>
                </div>
            )}

            {/* <Apartment /> */}
            {currentSubCategory && formData.isSell !== null && (
                <currentSubCategory.Component
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            )}
            {formData.isSell !== null && (
                <div className={styles.formGroup}>
                    <div className={styles.title}>Bạn là</div>
                    <div
                        className={styles.typeItem}
                        onClick={() => handleFormDataChange('isOwner', true)}
                    >
                        Cá nhân
                    </div>
                    <div
                        className={styles.typeItem}
                        onClick={() => handleFormDataChange('isOwner', false)}
                    >
                        Môi giới
                    </div>
                </div>
            )}
        </div>
    )
}

export default RealEstate
