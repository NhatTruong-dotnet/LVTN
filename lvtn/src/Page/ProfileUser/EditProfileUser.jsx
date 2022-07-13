import styles from './editprofile.module.css'
import Frame from '../../Common/Frame/Frame'
import ImagePicker from '../CreatePost/Components/ImagePicker'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import clsx from 'clsx'
import { useEffect, useState } from 'react'
import { convertFile, uploadImage } from '../../Utils/PostUtils'
import FormGroup from '../../features/Post/FormComponents/Components/FormGroup'
import FormInput from '../../features/Post/FormComponents/Components/FormInput'
import { useDispatch, useSelector } from 'react-redux'
import { useNavigate, useParams } from 'react-router-dom'
import {
    selectPendingState,
    selectUserInfo,
} from '../../features/User/UserSlice'
import { selectNumberPhone } from '../../features/Auth/Login/loginSlice'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'

function EditProfileUser(props) {
    const [listPreviewImage, setListPreviewImage] = useState([])
    const [listFileDataMedia, setListFileDataMedia] = useState([])
    const userInfo = useSelector(selectUserInfo)
    const [formData, setFormData] = useState({
        ten: userInfo.ten,
        diaChi: userInfo.diaChi,
        cmnd: userInfo.cmnd,
    })
    const dispatch = useDispatch()
    const navigate = useNavigate()
    const { profileUserNumberPhone } = useParams()
    const loginUserNumberPhone = useSelector(selectNumberPhone)
    const isLoading = useSelector(selectPendingState)

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
                { indexInFileData: listFileDataMedia.length, url },
            ])
        } else {
            emitMessage('error', 'File lựa chọn không hợp lệ')
            return
        }

        convertFile(e.target.files[0], dataSend => {
            setListFileDataMedia([dataSend])
        })
    }

    const deleteFile = (type, index, indexInFileData) => {
        if (type === 'image') {
            const newListPreviewImage = [...listPreviewImage]
            const deleteImageUrl = newListPreviewImage.splice(index, 1)
            URL.revokeObjectURL(deleteImageUrl)
            setListPreviewImage(newListPreviewImage)
        }

        const newListFileDataMedia = [...listFileDataMedia]
        newListFileDataMedia.splice(indexInFileData, 1)
        setListFileDataMedia(newListFileDataMedia)
    }

    const handleSubmitForm = async e => {
        e.preventDefault()
        let formRequestData = {
            ...formData,
        }

        if (listFileDataMedia.length !== 0) {
            const fileIdArray = await uploadImage(listFileDataMedia)
            formRequestData.anhDaiDienSource = fileIdArray[0].id
        }
        dispatch({
            type: 'updateProfileUser',
            payload: { sdt: profileUserNumberPhone, formData: formRequestData },
        })
    }

    useEffect(() => {
        if (loginUserNumberPhone !== profileUserNumberPhone) {
            navigate('/')
        }
    }, [loginUserNumberPhone, profileUserNumberPhone])

    useEffect(() => {
        document.title = `Chỉnh sửa: ${formData.ten}`
        return () => (document.title = 'STU')
    }, [])
    return (
        <div className='grid wide'>
            <DynamicModal showModal={isLoading} loading />
            <Frame>
                <div className='row'>
                    <div className='col l-3'>
                        <div className={styles.mediaPickerContainer}>
                            <input
                                type='file'
                                name='filePicker'
                                id='filePicker'
                                hidden
                                accept='ima ge/*'
                                onChange={handleSelectMediaFile}
                            />
                            <ImagePicker
                                listPreviewImage={listPreviewImage}
                                deleteFile={deleteFile}
                                title='Chọn 1 hình (không bắt buộc)'
                            />
                        </div>
                    </div>
                    <div className='col l-9'>
                        <FormGroup title={'Thông tin cá nhân'}>
                            <div className={styles.group}>
                                <FormInput
                                    require
                                    label={'Họ tên'}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'ten',
                                            e.target.value
                                        )
                                    }
                                    value={formData.ten}
                                />
                            </div>

                            <div className={styles.group}>
                                <FormInput
                                    require
                                    label={'Địa chỉ'}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'diaChi',
                                            e.target.value
                                        )
                                    }
                                    value={formData.diaChi}
                                />
                            </div>
                            <div className={styles.group}>
                                <FormInput
                                    require
                                    label={'Số CMND/Thẻ căn cước'}
                                    onChange={e =>
                                        handleFormDataChange(
                                            'cmnd',
                                            e.target.value
                                        )
                                    }
                                    value={formData.cmnd}
                                />
                            </div>
                        </FormGroup>
                        <div style={{ textAlign: 'right' }}>
                            <button
                                className={clsx(styles.button, styles.solid)}
                                onClick={handleSubmitForm}
                            >
                                Cập nhật
                            </button>
                        </div>
                    </div>
                </div>
            </Frame>
        </div>
    )
}

export default EditProfileUser
