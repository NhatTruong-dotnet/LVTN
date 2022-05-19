import clsx from 'clsx'
import Frame from '../../Common/Frame/Frame'
import CategoryPicker from './Components/CategoryPicker'
import styles from './createpost.module.css'
import { useEffect, useState } from 'react'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import {
    generateDefaultValueFormData,
    convertFile,
    uploadImage,
} from '../../Utils/PostUtils'

import { useDispatch, useSelector } from 'react-redux'
import {
    selectToken,
    selectUsername,
} from '../../features/Auth/Login/loginSlice'
import ImagePicker from './Components/ImagePicker'
import VideoPicker from './Components/VideoPicker'

function CreatePost(props) {
    const [isShowCategoryPicker, setIsShowCategoryPicker] = useState(true)
    const [listFileDataMedia, setListFileDataMedia] = useState([])
    const [listPreviewImage, setListPreviewImage] = useState([])
    const [listPreviewVideo, setListPreviewVideo] = useState([])
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
        medias: [],
    })
    const token = useSelector(selectToken)
    const numberPhone = useSelector(selectUsername)
    const dispatch = useDispatch()
    const openCategoryPicker = () => setIsShowCategoryPicker(true)
    const closeCategoryPicker = () => setIsShowCategoryPicker(false)

    const handleFormDataChange = (name, value) => {
        setFormData({
            ...formData,
            [name]: value,
        })
    }

    const handleSelectMediaFile = e => {
        console.log(e.target.files[0])
        if (!e.target.files[0]) {
            return
        }

        const file = e.target.files[0]
        const { type } = file

        if (type.match(/image/)) {
            const url = URL.createObjectURL(file)
            setListPreviewImage([
                ...listPreviewImage,
                { indexInFileData: listFileDataMedia.length, url },
            ])
        } else if (type.match(/video/)) {
            const url = URL.createObjectURL(file)
            setListPreviewVideo([
                ...listPreviewVideo,
                { indexInFileData: listFileDataMedia.length, url },
            ])
        } else {
            emitMessage('error', 'File lựa chọn không hợp lệ')
            return
        }

        convertFile(e.target.files[0], dataSend => {
            setListFileDataMedia([...listFileDataMedia, dataSend])
        })
    }

    const deleteFile = (type, index, indexInFileData) => {
        if (type === 'image') {
            const newListPreviewImage = [...listPreviewImage]
            const deleteImageUrl = newListPreviewImage.splice(index, 1)
            URL.revokeObjectURL(deleteImageUrl)
            setListPreviewImage(newListPreviewImage)
        } else {
            const newListPreviewVideo = [...listPreviewVideo]
            const deleteVideoUrl = newListPreviewVideo.splice(index, 1)
            URL.revokeObjectURL(deleteVideoUrl)
            setListPreviewVideo(newListPreviewVideo)
        }

        const newListFileDataMedia = [...listFileDataMedia]
        newListFileDataMedia.splice(indexInFileData, 1)
        setListFileDataMedia(newListFileDataMedia)
    }
    console.log(listFileDataMedia)

    const handleSubmitForm = async e => {
        e.preventDefault()

        const fileIdArray = await uploadImage(listFileDataMedia)
        const formRequestData = { ...formData, medias: fileIdArray }

        console.log(formRequestData)

        dispatch({
            type: 'createPost',
            formData: formRequestData,
            token,
            numberPhone,
        })
    }

    useEffect(() => {
        if (selectedCategory.category.id) {
            setFormData(
                generateDefaultValueFormData(
                    selectedCategory.category.id,
                    selectedCategory.subCategory?.id
                )
            )
        }
    }, [selectedCategory.category.id, selectedCategory.subCategory?.id])

    return (
        <div className='grid wide'>
            <Frame>
                <div className='row'>
                    <div className='col l-4'>
                        <div className={styles.mediaPickerContainer}>
                            <input
                                type='file'
                                name='filePicker'
                                id='filePicker'
                                hidden
                                accept='image/*,.mp4'
                                onChange={handleSelectMediaFile}
                            />
                            <ImagePicker
                                listPreviewImage={listPreviewImage}
                                deleteFile={deleteFile}
                            />

                            <VideoPicker
                                listPreviewVideo={listPreviewVideo}
                                deleteFile={deleteFile}
                            />
                        </div>
                    </div>
                    <div className='col l-8'>
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
                                    {selectedCategory.subCategory?.id
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

                            {selectedCategory.category.Component &&
                                selectedCategory.category.Component(
                                    selectedCategory.subCategory?.id,
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
                                        {formData.title.length}/50 ký tự
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
                                <div className={styles.hint}>
                                    {formData.description.length}/1500 ký tự
                                    (Tối thiểu 10 ký tự)
                                </div>
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
                                    onClick={handleSubmitForm}
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
