import { useEffect, useState } from 'react'
import Bed from './Bed'
import Cabinet from './Cabinet'
import Fan from './Fan'
import Kitchen from './Kitchen'
import KitchenTools from './KitchenTools'
import Lamp from './Lamp'
import SanitaryEquipment from './SanitaryEquipment'
import TableAndChair from './TableAndChair'
import Tree from './Tree'
import FurnitureAnother from './FurnitureAnother'

const subCategories = [
    {
        id: 43,
        Component: ({ formData, handleFormDataChange }) => (
            <TableAndChair
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 44,
        Component: ({ formData, handleFormDataChange }) => (
            <Cabinet
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 45,
        Component: ({ formData, handleFormDataChange }) => (
            <Bed
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 46,
        Component: ({ formData, handleFormDataChange }) => (
            <Kitchen
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 47,
        Component: ({ formData, handleFormDataChange }) => (
            <KitchenTools
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 48,
        Component: ({ formData, handleFormDataChange }) => (
            <Fan
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 49,
        Component: ({ formData, handleFormDataChange }) => (
            <Lamp
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 50,
        Component: ({ formData, handleFormDataChange }) => (
            <Tree
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 51,
        Component: ({ formData, handleFormDataChange }) => (
            <SanitaryEquipment
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 52,
        Component: ({ formData, handleFormDataChange }) => (
            <FurnitureAnother
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function Furniture({ subCategoryId, formData, handleFormDataChange }) {
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

export default Furniture
