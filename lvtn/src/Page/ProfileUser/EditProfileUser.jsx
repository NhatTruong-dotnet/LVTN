import styles from './editprofile.module.css'
import Frame from '../../Common/Frame/Frame'
import ImagePicker from '../CreatePost/Components/ImagePicker'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import clsx from 'clsx'
import { useEffect, useState } from 'react'
import { convertFile, uploadImage } from '../../Utils/PostUtils'
import FormGroup from '../../features/Post/FormComponents/Components/FormGroup'
import FormInput from '../../features/Post/FormComponents/Components/FormInput'

function EditProfileUser(props) {
    const [listPreviewImage, setListPreviewImage] = useState([])
    const [listFileDataMedia, setListFileDataMedia] = useState([])

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
        }

        const newListFileDataMedia = [...listFileDataMedia]
        newListFileDataMedia.splice(indexInFileData, 1)
        setListFileDataMedia(newListFileDataMedia)
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
                                onChange={handleSelectMediaFile}
                            />
                            <ImagePicker
                                listPreviewImage={listPreviewImage}
                                deleteFile={deleteFile}
                                multiple
                            />
                        </div>
                    </div>
                    <div className='col l-9'>
                        <FormGroup title={'Thông tin cá nhân'}>
                            <div className={styles.group}>
                                <FormInput require label={'Họ tên'} />
                            </div>
                            <div className={styles.group}>
                                <FormInput require label={'Số điện thoại'} />
                            </div>
                            <div className={styles.group}>
                                <FormInput require label={'Địa chỉ'} />
                            </div>
                            <div className={styles.group}>
                                <FormInput
                                    require
                                    label={'Số CMND/Thẻ căn cước'}
                                />
                                <div
                                    className={styles.group}
                                    style={{
                                        display: 'flex',
                                        justifyContent: 'space-between',
                                        marginTop: 20,
                                    }}
                                >
                                    <ImagePicker
                                        listPreviewImage={listPreviewImage}
                                        deleteFile={deleteFile}
                                        style={{ width: 350 }}
                                    />
                                    <ImagePicker
                                        listPreviewImage={listPreviewImage}
                                        deleteFile={deleteFile}
                                        style={{ width: 350 }}
                                    />
                                </div>
                            </div>
                        </FormGroup>
                        <div style={{ textAlign: 'right' }}>
                            <button
                                className={clsx(styles.button, styles.solid)}
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
