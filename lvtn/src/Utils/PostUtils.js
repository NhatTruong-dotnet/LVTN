const array = [
    {
        categoryId: 1,
        subCategories: [
            // Apartment
            {
                subCategoryId: 13,
                isSell: null,
                isHandOver: null,
                name: '',
                address: {
                    city: '',
                    district: '',
                    ward: '',
                    street: '',
                    number: '',
                },
                apartmentId: '',
                block: '',
                floor: '',
                apartmentType: '',
                amountBedroom: '',
                amountToilet: '',
                balcony: '',
                mainDoor: '',
                exhibit: '',
                furniture: '',
                acreage: '',
                price: '',
                deposit: '',
                isOwner: null,
            },
            // House
            {
                subCategoryId: 14,
                isSell: null,
                isHandOver: null,
                name: '',
                address: {
                    city: '',
                    district: '',
                    ward: '',
                    street: '',
                    number: '',
                },
                houseId: '',
                block: '',
                floor: '',
                houseType: '',
                amountBedroom: '',
                amountToilet: '',
                mainDoor: '',
                exhibit: '',
                furniture: '',
                isAlley: false,
                hasBackyard: false,
                acreage: '',
                useAcreage: '',
                horizontal: '',
                vertical: '',
                price: '',
                deposit: '',
                isOwner: null,
            },
            // Land
            {
                subCategoryId: 15,
                isSell: null,
                name: '',
                address: {
                    city: '',
                    district: '',
                    ward: '',
                    street: '',
                    number: '',
                },
                landId: '',
                block: '',
                isFacade: false,
                landType: '',
                landDirection: '',
                exhibit: '',
                isAlley: false,
                hasBackyard: false,
                acreage: '',
                horizontal: '',
                vertical: '',
                price: '',
                deposit: '',
                isOwner: null,
            },
            // Office
            {
                subCategoryId: 16,
                isSell: null,
                name: '',
                address: {
                    city: '',
                    district: '',
                    ward: '',
                    street: '',
                    number: '',
                },
                officeId: '',
                block: '',
                floor: '',
                officeType: '',
                officeDirection: '',
                exhibit: '',
                furniture: '',
                acreage: '',
                price: '',
                deposit: '',
                isOwner: null,
            },
            // Motel
            {
                subCategoryId: 17,
                name: '',
                address: {
                    city: '',
                    district: '',
                    ward: '',
                    street: '',
                    number: '',
                },
                furniture: '',
                acreage: '',
                price: '',
                deposit: '',
                isOwner: null,
            },
        ],
    },
]

export const generateDefaultValueFormData = (id, subCategoryId) => {
    let defaultFormData = {
        title: '',
        description: '',
        mediaIds: [],
    }
    array.forEach(({ categoryId, subCategories }) => {
        if (id === categoryId) {
            defaultFormData.categoryId = id
            subCategories.forEach(subCategory => {
                if (subCategory.subCategoryId === subCategoryId) {
                    defaultFormData = {
                        ...defaultFormData,
                        ...subCategory,
                    }
                }
            })
        }
    })

    return defaultFormData
}

export function convertFile(file, callback) {
    const reader = new FileReader() //this for convert to Base64
    reader.readAsDataURL(file) //start conversion...

    reader.onload = function (e) {
        //.. once finished..
        const rawLog = reader.result.split(',')[1] //extract only thee file data part
        const dataSend = {
            dataReq: { data: rawLog, name: file.name, type: file.type },
            fname: 'uploadFilesToGoogleDrive',
        } //preapre info to send to API
        callback({ type: file.type, fileData: dataSend })
    }
}

export const uploadImage = async files => {
    const fileIdArray = await Promise.all(
        files.map(async ({ type, fileData }) => {
            const res = await fetch(
                'https://script.google.com/macros/s/AKfycbwXhX4N82ic3vhrVOK493pjOfR9-pISPf7jsSmpiBcf_IHuQCc/exec',
                { method: 'POST', body: JSON.stringify(fileData) }
            )
            const { id } = await res.json()
            return { type, id }
        })
    )
    return fileIdArray
}
