import clsx from 'clsx'
import Frame from '../../Common/Frame/Frame'
import CategoryPicker from './Components/CategoryPicker'
import styles from './createpost.module.css'
import { useEffect, useState } from 'react'

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
        ],
    },
]

const generateDefaultValueFormData = (id, subCategoryId) => {
    let result = {
        title: '',
        description: '',
        mediaIds: [],
    }
    array.forEach(({ categoryId, subCategories }) => {
        if (id === categoryId) {
            result.categoryId = id
            subCategories.forEach(subCategory => {
                if (subCategory.subCategoryId === subCategoryId) {
                    result = {
                        ...result,
                        ...subCategory,
                    }
                }
            })
        }
    })

    return result
}

function CreatePost(props) {
    const [isShowCategoryPicker, setIsShowCategoryPicker] = useState(true)
    const [listMedia, setListMedia] = useState([])
    const [selectedCategory, setSelectedCategory] = useState({
        category: {
            id: null,
            name: null,
            Component: null,
        },
        subCategory: {
            id: null,
            name: null,
        },
    })
    const [formData, setFormData] = useState({
        title: '',
        description: '',
        mediaIds: [],
    })
    const openCategoryPicker = () => setIsShowCategoryPicker(true)
    const closeCategoryPicker = () => setIsShowCategoryPicker(false)

    useEffect(() => {
        if (selectedCategory.category.id) {
            setFormData(
                generateDefaultValueFormData(
                    selectedCategory.category.id,
                    selectedCategory.subCategory.id
                )
            )
        }
    }, [selectedCategory.category.id, selectedCategory.subCategory.id])

    console.log(formData)

    const handleFormDataChange = (name, value) => {
        setFormData({
            ...formData,
            [name]: value,
        })
    }

    return (
        <div className='grid wide'>
            <Frame>
                <div className='row'>
                    <div className='col l-3'>
                        <div className={styles.mediaPickerContainer}>
                            <input
                                type='file'
                                name='filePicker'
                                id='filePicker'
                                hidden
                                accept='image/*,.mp4'
                                onChange={e => {
                                    if (e.target.files[0]) {
                                        setListMedia([
                                            ...listMedia,
                                            e.target.files[0],
                                        ])
                                    }
                                }}
                            />
                            <label
                                htmlFor='filePicker'
                                className={styles.imagePicker}
                            >
                                <svg
                                    xmlns='http://www.w3.org/2000/svg'
                                    width='53'
                                    height='39'
                                    viewBox='0 0 53 39'
                                >
                                    <g
                                        fill='none'
                                        fillRule='evenodd'
                                        stroke='none'
                                        strokeWidth='1'
                                    >
                                        <g
                                            stroke='#FE9900'
                                            strokeWidth='2'
                                            transform='translate(-255 -179)'
                                        >
                                            <g transform='translate(132 122)'>
                                                <path d='M150.631 87.337c-5.755 0-10.42-4.534-10.42-10.127 0-5.593 4.665-10.127 10.42-10.127s10.42 4.534 10.42 10.127c0 5.593-4.665 10.127-10.42 10.127m10.42-24.755l-2.315-4.501h-16.21l-2.316 4.5h-11.579s-4.631 0-4.631 4.502v22.505c0 4.5 4.631 4.5 4.631 4.5h41.684s4.631 0 4.631-4.5V67.083c0-4.501-4.631-4.501-4.631-4.501h-9.263z'></path>
                                            </g>
                                        </g>
                                    </g>
                                </svg>
                                <div className={styles.text}>
                                    Đăng từ 3 đến 10 hình
                                </div>
                            </label>
                            <label
                                htmlFor='filePicker'
                                className={styles.videoPicker}
                            >
                                <svg
                                    xmlns='http://www.w3.org/2000/svg'
                                    width='53'
                                    height='39'
                                    viewBox='0 0 53 39'
                                >
                                    <path
                                        fill='#fff'
                                        stroke='#FE9900'
                                        strokeWidth={2}
                                        d='M39.62 11.031l.013-.006.012-.006 11.707-6.042a1.329 1.329 0 01.208-.076l.007.003.128.025c.28.054.305.221.305.228v26.046a.412.412 0 01-.07.095.704.704 0 01-.203.145h-.122c-.073 0-.126 0-.176-.002h-.024l-.031-.017-11.721-6.183-.016-.008-.017-.008c-.16-.077-.41-.363-.41-.847v-12.5c0-.484.25-.77.41-.847zm11.716 20.404h.001-.001z'
                                    ></path>
                                    <mask
                                        id='path-2-inside-1_289_1913'
                                        fill='#fff'
                                    >
                                        <path
                                            fillRule='evenodd'
                                            d='M10.447 7c1.81 0 3.234 1.466 3.234 3.333 0 1.867-1.423 3.333-3.234 3.333S7.213 12.2 7.213 10.333C7.213 8.466 8.636 7 10.447 7zM28.07 36.167c4.656 0 8.537-4 8.537-8.8v-18.4c0-4.8-3.88-8.8-8.537-8.8H8.537C3.881.167 0 4.167 0 8.967v18.4c0 4.934 3.751 8.8 8.537 8.8H28.07z'
                                            clipRule='evenodd'
                                        ></path>
                                    </mask>
                                    <path
                                        fill='#FE9900'
                                        d='M10.447 9c.65 0 1.234.513 1.234 1.333h4C15.68 7.419 13.419 5 10.447 5v4zm1.234 1.333c0 .82-.584 1.333-1.234 1.333v4c2.972 0 5.234-2.42 5.234-5.333h-4zm-1.234 1.333c-.65 0-1.234-.513-1.234-1.333h-4c0 2.914 2.262 5.333 5.234 5.333v-4zm-1.234-1.333c0-.82.584-1.333 1.234-1.333V5c-2.972 0-5.234 2.42-5.234 5.333h4zM28.07 38.167c5.818 0 10.537-4.953 10.537-10.8h-4c0 3.753-3.042 6.8-6.537 6.8v4zm10.537-10.8v-18.4h-4v18.4h4zm0-18.4c0-5.847-4.72-10.8-10.537-10.8v4c3.495 0 6.537 3.047 6.537 6.8h4zM28.07-1.833H8.537v4H28.07v-4zm-19.533 0C2.72-1.833-2 3.12-2 8.967h4c0-3.753 3.042-6.8 6.537-6.8v-4zM-2 8.967v18.4h4v-18.4h-4zm0 18.4c0 5.98 4.59 10.8 10.537 10.8v-4c-3.624 0-6.537-2.913-6.537-6.8h-4zm10.537 10.8H28.07v-4H8.537v4z'
                                        mask='url(#path-2-inside-1_289_1913)'
                                    ></path>
                                </svg>
                                <div className={styles.text}>Đăng 1 video</div>
                            </label>
                        </div>
                    </div>
                    <div className='col l-9'>
                        <div className={styles.formContainer}>
                            <div className={styles.inputContainer}>
                                {isShowCategoryPicker && (
                                    <CategoryPicker
                                        closeCategoryPicker={
                                            closeCategoryPicker
                                        }
                                        selectedCategory={selectedCategory}
                                        setSelectedCategory={
                                            setSelectedCategory
                                        }
                                    />
                                )}
                                <div
                                    className={styles.categoryPicker}
                                    onClick={openCategoryPicker}
                                >
                                    {selectedCategory.category.name}
                                    {selectedCategory.subCategory.id
                                        ? `${
                                              ' - ' +
                                              selectedCategory?.subCategory
                                                  ?.name
                                          }`
                                        : ''}
                                </div>
                                <label
                                    className={clsx(styles.label, {
                                        [styles.hasValue]: Boolean(
                                            selectedCategory.category.id
                                        ),
                                    })}
                                >
                                    Danh mục tin đăng
                                </label>
                                <svg
                                    data-type='monochrome'
                                    xmlns='http://www.w3.org/2000/svg'
                                    viewBox='0 0 512 512'
                                    width='1em'
                                    height='1em'
                                    fill='none'
                                    className='arrow'
                                >
                                    <path
                                        d='M7.9 156.8l2.8 3.3 214.8 247.2c7.3 8.4 18.2 13.6 30.3 13.6 12.2 0 23.1-5.4 30.3-13.6l214.7-246.7 3.6-4.1c2.7-3.9 4.3-8.7 4.3-13.7 0-13.7-11.7-25-26.2-25h-453c-14.5 0-26.2 11.2-26.2 25 0 5.2 1.7 10.1 4.6 14z'
                                        fill='currentColor'
                                    ></path>
                                </svg>
                            </div>
                            {/* <RealEstate /> */}
                            {/* no display if FormComponent is null */}
                            {/* {selectedCategory.subCategory.Component ? (
                                <Apartment />
                            ) : (
                                ''
                            )} */}
                            {/* {ComponentFormDisplay && <ComponentFormDisplay />} */}
                            {selectedCategory.category.Component &&
                                // selectedCategory.category.Component(
                                //     selectedCategory.subCategory.id
                                // )
                                selectedCategory.category.Component(
                                    selectedCategory.subCategory.id,
                                    formData,
                                    handleFormDataChange
                                )}
                            <div className={styles.formGroup}>
                                <div className={styles.title}>
                                    Tiêu đề tin đăng và Mô tả chi tiết
                                </div>
                                <div className={styles.group}>
                                    <div className={styles.inputGroup}>
                                        <input
                                            type='text'
                                            className={styles.input}
                                            value={formData.title}
                                            onChange={e =>
                                                handleFormDataChange(
                                                    'title',
                                                    e.target.value
                                                )
                                            }
                                        />

                                        <label
                                            className={clsx(styles.label, {
                                                [styles.hasValue]: Boolean(
                                                    formData.title
                                                ),
                                            })}
                                        >
                                            Tiêu đề tin đăng
                                            <span className={styles.required}>
                                                *
                                            </span>
                                        </label>
                                    </div>
                                    {/* <div className={styles.formMessage}></div> */}
                                    <div className={styles.hint}>
                                        0/50 ký tự
                                    </div>
                                </div>

                                <div className={styles.inputGroup}>
                                    <textarea
                                        type='text'
                                        className={clsx(
                                            styles.input,
                                            styles.textarea
                                        )}
                                        value={formData.description}
                                        onChange={e =>
                                            handleFormDataChange(
                                                'description',
                                                e.target.value
                                            )
                                        }
                                        placeholder={`                                        
Ví dụ:- Căn hộ 2PN 68m2 Celadon City, Q.Tân Phú
        Nên viết tiếng Việt có dấu
        Không:
        - Không ghi "Cần bán"
        - Không chèn giá và số điện thoại ở tiêu đề`}
                                    />
                                    <label className={clsx(styles.label)}>
                                        Mô tả chi tiết
                                        <span className={styles.required}>
                                            *
                                        </span>
                                    </label>
                                </div>
                                {/* <div className={styles.formMessage}></div> */}
                                <div className={styles.hint}>0/50 ký tự</div>
                            </div>

                            <div className={styles.buttonGroup}>
                                <button
                                    className={clsx(
                                        styles.button,
                                        styles.outline
                                    )}
                                >
                                    Xem trước
                                </button>
                                <button
                                    className={clsx(
                                        styles.button,
                                        styles.solid
                                    )}
                                >
                                    Đăng tin
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </Frame>
        </div>
    )
}

export default CreatePost
