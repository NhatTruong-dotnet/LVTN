import { useEffect, useState } from 'react'
import AirConditioner from './AirConditioner'
import Fridge from './Fridge'
import WashingMachine from './WashingMachine'

const subCategories = [
    {
        id: 40,
        Component: ({ formData, handleFormDataChange }) => (
            <Fridge
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 41,
        Component: ({ formData, handleFormDataChange }) => (
            <AirConditioner
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 42,
        Component: ({ formData, handleFormDataChange }) => (
            <WashingMachine
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function HouseWare({ subCategoryId, formData, handleFormDataChange }) {
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

export default HouseWare
