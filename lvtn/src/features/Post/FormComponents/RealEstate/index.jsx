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
    {
        id: 15,
        Component: ({ formData, handleFormDataChange }) => (
            <Land
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 16,
        Component: ({ formData, handleFormDataChange }) => (
            <Office
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 17,
        Component: ({ formData, handleFormDataChange }) => (
            <Motel
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
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
            {formData.subCategoryId !== 17 && (
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
            )}
            {formData.isSell &&
                formData.subCategoryId !== 15 &&
                formData.subCategoryId !== 16 && (
                    <div className={styles.type}>
                        <div className={styles.title}>
                            Tình trạng bất động sản{' '}
                            <span className={styles.required}>*</span>
                        </div>
                        <div
                            onClick={() =>
                                handleFormDataChange('isHandOver', true)
                            }
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    formData.isHandOver &&
                                    formData.isHandOver !== null,
                            })}
                        >
                            Đã bàn giao
                        </div>
                        <div
                            className={clsx(styles.typeItem, {
                                [styles.active]:
                                    !formData.isHandOver &&
                                    formData.isHandOver !== null,
                            })}
                            onClick={() =>
                                handleFormDataChange('isHandOver', false)
                            }
                        >
                            Chưa bàn giao
                        </div>
                        <div className={styles.formMessage}></div>
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
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                formData.isOwner && formData.isOwner !== null,
                        })}
                        onClick={() => handleFormDataChange('isOwner', true)}
                    >
                        Cá nhân
                    </div>
                    <div
                        className={clsx(styles.typeItem, {
                            [styles.active]:
                                !formData.isOwner && formData.isOwner !== null,
                        })}
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
