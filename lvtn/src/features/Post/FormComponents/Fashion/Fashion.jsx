import { useEffect, useState } from 'react'
import Clothes from './Clothes'
import Watch from './Watch'
import Footwear from './Footwear'
import HandBag from './HandBag'
import Perfume from './Perfume'
import FashionAccessories from './FashionAccessories'

const subCategories = [
    {
        id: 53,
        Component: ({ formData, handleFormDataChange }) => (
            <Clothes
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 54,
        Component: ({ formData, handleFormDataChange }) => (
            <Watch
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 55,
        Component: ({ formData, handleFormDataChange }) => (
            <Footwear
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 56,
        Component: ({ formData, handleFormDataChange }) => (
            <HandBag
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 57,
        Component: ({ formData, handleFormDataChange }) => (
            <Perfume
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 58,
        Component: ({ formData, handleFormDataChange }) => (
            <FashionAccessories
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function Fashion({ subCategoryId, formData, handleFormDataChange }) {
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

export default Fashion
