import { useEffect, useState } from 'react'
import Bird from './Bird'
import Chicken from './Chicken'
import Dog from './Dog'
import Cat from './Cat'
import AnotherPet from './AnotherPet'
import PetService from './PetService'

const subCategories = [
    {
        id: 34,
        Component: ({ formData, handleFormDataChange }) => (
            <Chicken
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 35,
        Component: ({ formData, handleFormDataChange }) => (
            <Dog
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 36,
        Component: ({ formData, handleFormDataChange }) => (
            <Bird
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 37,
        Component: ({ formData, handleFormDataChange }) => (
            <Cat
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 38,
        Component: ({ formData, handleFormDataChange }) => (
            <AnotherPet
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 39,
        Component: ({ formData, handleFormDataChange }) => (
            <PetService
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function Pet({ subCategoryId, formData, handleFormDataChange }) {
    const [currentSubCategory, setCurrentSubCategory] = useState(null)
    console.log(formData)

    useEffect(() => {
        const element = subCategories.find(({ id }) => id === subCategoryId)
        setCurrentSubCategory(element)
    }, [subCategoryId])
    return (
        <>
            <>
                {currentSubCategory && formData.canBan !== null && (
                    <currentSubCategory.Component
                        formData={formData}
                        handleFormDataChange={handleFormDataChange}
                    />
                )}
            </>
        </>
    )
}

export default Pet
