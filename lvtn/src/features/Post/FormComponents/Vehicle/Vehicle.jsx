import clsx from 'clsx'
import { useEffect, useState } from 'react'
import styles from './vehicle.module.css'
import Another from './Another'
import Bicycle from './Bicycle'
import Car from './Car'
import Motorcycle from './Motorcycle'
import SpareParts from './SpareParts'
import ElectricBike from './ElectricBike'
import Truck from './Truck'

const subCategories = [
    {
        id: 18,
        Component: ({ formData, handleFormDataChange }) => (
            <Car
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 19,
        Component: ({ formData, handleFormDataChange }) => (
            <Motorcycle
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 20,
        Component: ({ formData, handleFormDataChange }) => (
            <Truck
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 21,
        Component: ({ formData, handleFormDataChange }) => (
            <ElectricBike
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 22,
        Component: ({ formData, handleFormDataChange }) => (
            <Bicycle
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 23,
        Component: ({ formData, handleFormDataChange }) => (
            <Another
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
    {
        id: 24,
        Component: ({ formData, handleFormDataChange }) => (
            <SpareParts
                handleFormDataChange={handleFormDataChange}
                formData={formData}
            />
        ),
    },
]

function Vehicle(props) {
    return <div></div>
}

export default Vehicle
