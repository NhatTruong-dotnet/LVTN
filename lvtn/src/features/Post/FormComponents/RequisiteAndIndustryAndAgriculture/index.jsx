import { useEffect, useState } from 'react'
import Requisite from './Requisite'
import Rest from './Rest'

const subCategories = [
    {
        id: 65,
        Component: ({ formData, handleFormDataChange }) => (
            <Requisite
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 66,
        Component: ({ formData, handleFormDataChange }) => (
            <Rest
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]
function RequisiteAndIndustryAndAgriculture({
    subCategoryId,
    formData,
    handleFormDataChange,
}) {
    const [currentSubCategory, setCurrentSubCategory] = useState(null)
    console.log(formData)

    useEffect(() => {
        const element = subCategories.find(({ id }) => id === subCategoryId)
        setCurrentSubCategory(element)
    }, [subCategoryId])
    return (
        <>
            {currentSubCategory && (
                <currentSubCategory.Component
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            )}
        </>
    )
}

export default RequisiteAndIndustryAndAgriculture
