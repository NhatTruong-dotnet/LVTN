import MobilePhone from './MobilePhone'
import Tablet from './Tablet'
import ElectronicComponents from './ElectronicComponents'
import Accessory from './Accessory'
import Laptop from './Laptop'
import Desktop from './Desktop'
import SmartDevice from './SmartDevice'
import Television from './Television'
import Camera from './Camera'
import { useEffect, useState } from 'react'

const subCategories = [
    {
        id: 25,
        Component: ({ formData, handleFormDataChange }) => (
            <MobilePhone
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 26,
        Component: ({ formData, handleFormDataChange }) => (
            <Tablet
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 27,
        Component: ({ formData, handleFormDataChange }) => (
            <Laptop
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 28,
        Component: ({ formData, handleFormDataChange }) => (
            <Desktop
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 29,
        Component: ({ formData, handleFormDataChange }) => (
            <Camera
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 30,
        Component: ({ formData, handleFormDataChange }) => (
            <Television
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 31,
        Component: ({ formData, handleFormDataChange }) => (
            <SmartDevice
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 32,
        Component: ({ formData, handleFormDataChange }) => (
            <Accessory
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 33,
        Component: ({ formData, handleFormDataChange }) => (
            <ElectronicComponents
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]
function ElectronicDevice({ subCategoryId, formData, handleFormDataChange }) {
    const [currentSubCategory, setCurrentSubCategory] = useState(null)
    console.log(formData)

    useEffect(() => {
        const element = subCategories.find(({ id }) => id === subCategoryId)
        setCurrentSubCategory(element)
    }, [subCategoryId])

    return (
        <>
            {currentSubCategory && formData.canBan !== null && (
                <currentSubCategory.Component
                    formData={formData}
                    handleFormDataChange={handleFormDataChange}
                />
            )}
        </>
    )
}

export default ElectronicDevice
