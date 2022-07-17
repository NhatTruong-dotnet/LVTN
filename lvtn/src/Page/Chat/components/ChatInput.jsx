import { useState } from 'react'
import styles from '../chat.module.css'
import clsx from 'clsx'
import { IoIosSend } from 'react-icons/io'
import { ImAttachment } from 'react-icons/im'
import { TiDeleteOutline } from 'react-icons/ti'
import { useDispatch } from 'react-redux'
import { uploadImage } from '../../../Utils/PostUtils'
import { selectLoginStatus } from '../../../features/Auth/Login/loginSlice'
import { useSelector } from 'react-redux'

function ChatInput({
    listPreviewImage,
    listFileDataMedia,
    handleSelectMediaFile,
    deleteFile,
    deleteAllFile,
}) {
    const [messageText, setTextMessage] = useState('')
    const dispatch = useDispatch()
    const isLogin = useSelector(selectLoginStatus)

    const handleAddNewMessage = async () => {
        if (!isLogin) {
            window.showLoginForm()
        }
        const responseArray = await uploadImage(listFileDataMedia)
        let imageId = ''
        if (responseArray.length !== 0) {
            imageId = responseArray[0].id
        }
        dispatch({
            type: 'addNewMessage',
            messageText,
            imageId,
        })
        setTextMessage('')
        deleteAllFile()
    }

    return (
        <div className={styles.chatInputContainer}>
            <div className={styles.wrapChatInput}>
                <div className={styles.listImageUpload}>
                    {listPreviewImage.map(({ url, indexInFileData }, index) => (
                        <div
                            className={styles.imageUploadWrapper}
                            key={indexInFileData}
                        >
                            <img
                                src={url}
                                alt='img'
                                width={50}
                                height={50}
                                className={styles.imageUpload}
                            />
                            <TiDeleteOutline
                                className={styles.deleteImageUpload}
                                onClick={() =>
                                    deleteFile('image', index, indexInFileData)
                                }
                            />
                        </div>
                    ))}
                    {listPreviewImage.length === 0 ? (
                        ''
                    ) : (
                        <label
                            htmlFor='imageMessage'
                            className={styles.addNewImage}
                        >
                            <span className={styles.addImageIcon}></span>
                        </label>
                    )}
                </div>
                <input
                    className={clsx(styles.chatInput)}
                    placeholder='Text here ...'
                    type='text'
                    value={messageText}
                    onChange={e => setTextMessage(e.target.value)}
                />
            </div>
            <input
                type='file'
                id='imageMessage'
                hidden
                onChange={handleSelectMediaFile}
            />
            <label htmlFor='imageMessage' className={styles.attach}>
                <ImAttachment />
            </label>
            {/* <div className={styles.line}></div> */}
            <IoIosSend
                className={styles.sendMessage}
                onClick={handleAddNewMessage}
            />
        </div>
    )
}

export default ChatInput
