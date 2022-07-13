import clsx from 'clsx'
import Frame from '../../Common/Frame/Frame'
import CategoryPicker from './Components/CategoryPicker'
import styles from './createpost.module.css'
import { useEffect, useState } from 'react'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import {
    generateDefaultValueFormData,
    convertFile,
    getCategory,
    getSubCategory,
} from '../../Utils/PostUtils'

import { useDispatch, useSelector } from 'react-redux'
import { selectLoginStatus } from '../../features/Auth/Login/loginSlice'
import ImagePicker from './Components/ImagePicker'
import VideoPicker from './Components/VideoPicker'
import { useLocation, useNavigate, useParams } from 'react-router-dom'
import {
    createPostPending,
    selectFormMode,
    selectPendingStatusPost,
    selectUpdatePost,
    setFormMode,
} from '../../features/Post/PostSlice'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'
import { uploadImage } from '../../Utils/PostUtils'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function CreatePost() {
    const updatePost = useSelector(selectUpdatePost)
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

    const isLogin = useSelector(selectLoginStatus)
    const dispatch = useDispatch()
    const isLoading = useSelector(selectPendingStatusPost)
    const formMode = useSelector(selectFormMode)
    const { pathname } = useLocation()
    const { idPost, preflightKey } = useParams()

    const openCategoryPicker = () => setIsShowCategoryPicker(true)
    const closeCategoryPicker = () => setIsShowCategoryPicker(false)

    const handleFormDataChange = (name, value) => {
        setFormData({
            ...formData,
            [name]: value,
        })
    }

    const handleSelectMediaFile = e => {
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

    const handleSubmitForm = async e => {
        e.preventDefault()

        const listErrorMessage = document.querySelectorAll(
            '[class*="formMessage"]'
        )
        const listInputGroup = document.querySelectorAll(
            '[class*="inputGroup"]'
        )
        let validForm = true

        for (let formMessage of listErrorMessage) {
            if (formMessage.textContent) {
                validForm = false
                break
            }
        }
        for (let inputGroup of listInputGroup) {
            if (
                !inputGroup.childNodes[0].value &&
                inputGroup.childNodes[0].getAttribute('isrequire') === 'true'
            ) {
                validForm = false
                break
            }
        }

        if (listPreviewImage.length > 6) {
            validForm = false
            emitMessage('error', 'Bạn chỉ có thể chọn tối đa 6 hình')
        } else if (listPreviewImage.length === 0) {
            validForm = false
            emitMessage('error', 'Bạn chưa chọn hình')
        }

        if (listPreviewVideo.length > 2) {
            validForm = false
            emitMessage('error', 'Bạn chỉ có thể chọn tối đa 2 video')
        }

        if (validForm) {
            dispatch(createPostPending())
            const fileIdArray = await uploadImage(listFileDataMedia)
            const formRequestData = { ...formData, medias: fileIdArray }
            if (formMode === 'add') {
                dispatch({
                    type: 'createPost',
                    formData: formRequestData,
                })
            } else {
                dispatch({
                    type: 'editPost',
                    formData: formRequestData,
                    preflightKey,
                })
            }
        } else {
            emitMessage('error', 'Bạn chưa điền đầy đủ thông tin hợp lệ')
        }
    }

    useEffect(() => {
        if (pathname.includes('edit-post')) {
            dispatch(setFormMode({ formMode: 'edit' }))
        }
    }, [pathname])

    useEffect(() => {
        if (idPost && preflightKey) {
            dispatch({ type: 'getEditPostData', idPost, preflightKey })
        }
    }, [idPost, preflightKey])

    useEffect(() => {
        if (
            pathname.includes('edit-post') &&
            Object.keys(updatePost).length !== 0 &&
            isLogin
        ) {
            setFormData({
                ...updatePost,
                title: updatePost.tieuDe,
                description: updatePost.mota,
                medias: [],
            })
            const updateCategory = getCategory(updatePost.idDanhMucCha)
            const updateSubcategory = getSubCategory(
                updatePost.idDanhMucCha,
                updatePost.idDanhMucCon
            )
            setSelectedCategory({
                category: {
                    id: updateCategory.id,
                    name: updateCategory.name,
                    Component: updateCategory.Component,
                },
                subCategory: updateSubcategory,
            })

            const { hinhAnh_BaiDangs } = updatePost
            const imageArray = []
            const videoArray = []

            hinhAnh_BaiDangs.forEach(({ type, id }, index) => {
                if (type === 'png') {
                    imageArray.push({
                        indexInFileData: index,
                        url: `${imgURL}${id}`,
                    })
                } else {
                    videoArray.push({
                        indexInFileData: index,
                        url: `${imgURL}${id}`,
                    })
                }
            })
            setListPreviewImage(imageArray)
            setListPreviewVideo(videoArray)
            setListFileDataMedia(hinhAnh_BaiDangs)
        }
    }, [pathname, updatePost, isLogin])

    useEffect(() => {
        if (!isLogin) {
            if (typeof window.showLoginForm === 'function') {
                window.showLoginForm()
            }
        }
    }, [isLogin])

    useEffect(() => {
        if (selectedCategory.category.id && !pathname.includes('edit-post')) {
            setFormData(
                generateDefaultValueFormData(
                    selectedCategory.category.id,
                    selectedCategory.subCategory?.id
                )
            )
        }
    }, [selectedCategory.category.id, selectedCategory.subCategory?.id])

    useEffect(() => {
        dispatch({ type: 'loadLocationData' })
    }, [])
    return (
        <div className='grid wide'>
            <DynamicModal showModal={isLoading} loading />
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
                                multiple
                            />

                            <VideoPicker
                                listPreviewVideo={listPreviewVideo}
                                deleteFile={deleteFile}
                                multiple
                            />
                        </div>
                    </div>
                    <div className='col l-8'>
                        <div className={styles.formContainer}>
                            {!pathname.includes('edit-post') && (
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
                            )}

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
                                        {formData.title?.length}/50 ký tự
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
                                    />
                                    <label
                                        className={clsx(styles.label, {
                                            [styles.hasValue]: Boolean(
                                                formData.description
                                            ),
                                        })}
                                    >
                                        Mô tả chi tiết
                                        <span className={styles.required}>
                                            *
                                        </span>
                                    </label>
                                </div>
                                {/* <div className={styles.formMessage}></div> */}
                                <div className={styles.hint}>
                                    {formData.description?.length}/1500 ký tự
                                    (Tối thiểu 10 ký tự)
                                </div>
                            </div>

                            <div className={styles.buttonGroup}>
                                {/* <button
                                    className={clsx(
                                        styles.button,
                                        styles.outline
                                    )}
                                >
                                    Xem trước
                                </button> */}
                                <button
                                    className={clsx(
                                        styles.button,
                                        styles.solid
                                    )}
                                    onClick={handleSubmitForm}
                                >
                                    {pathname.includes('edit-post')
                                        ? 'Chỉnh sửa tin'
                                        : 'Đăng tin'}
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
