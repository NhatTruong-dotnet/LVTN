import { useEffect, useState } from 'react'
import MusicalInstrument from './MusicalInstrument'
import Book from './Book'
import SportsWear from './SportsWear'
import Collectibles from './Collectibles'
import GamingDevice from './GamingDevice'
import Other from './Other'

const subCategories = [
    {
        id: 59,
        Component: ({ formData, handleFormDataChange }) => (
            <MusicalInstrument
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 60,
        Component: ({ formData, handleFormDataChange }) => (
            <Book
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 61,
        Component: ({ formData, handleFormDataChange }) => (
            <SportsWear
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 62,
        Component: ({ formData, handleFormDataChange }) => (
            <Collectibles
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 63,
        Component: ({ formData, handleFormDataChange }) => (
            <GamingDevice
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 64,
        Component: ({ formData, handleFormDataChange }) => (
            <Other
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function Entertainment({ subCategoryId, formData, handleFormDataChange }) {
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

export default Entertainment
