import { useEffect, useRef, useState } from 'react'
import { Col, Container, Row, Input } from 'reactstrap'
import styles from './chat.module.css'
import clsx from 'clsx'
// import { FiEdit } from 'react-icons/fi'
import { IoIosSend } from 'react-icons/io'
import { ImAttachment } from 'react-icons/im'
import { TiDeleteOutline } from 'react-icons/ti'
import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import { convertFile } from '../../Utils/PostUtils'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'
import TabContainer from '../../Common/TabContainer'

function Chat(props) {
    const [textMessage, setTextMessage] = useState('')
    const [selectViewImageUrl, setSelectViewImageUrl] = useState('')
    const [listPreviewImage, setListPreviewImage] = useState([])
    const [listFileDataMedia, setListFileDataMedia] = useState([])

    const conversationRef = useRef()

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

    const clearAllImageSelect = () => {
        listPreviewImage.forEach(({ url }) => {
            URL.revokeObjectURL(url)
        })
        setListPreviewImage([])
        setListFileDataMedia([])
    }

    const deleteFile = (type, index, indexInFileData) => {
        if (type === 'image') {
            const newListPreviewImage = [...listPreviewImage]
            const deleteImage = newListPreviewImage.splice(index, 1)
            console.log(deleteImage)
            URL.revokeObjectURL(deleteImage[0].url)
            setListPreviewImage(newListPreviewImage)
        }

        const newListFileDataMedia = [...listFileDataMedia]
        newListFileDataMedia.splice(indexInFileData, 1)
        setListFileDataMedia(newListFileDataMedia)
    }

    useEffect(() => {
        conversationRef.current.scrollTop = conversationRef.current.scrollHeight
    }, [])

    useEffect(() => {
        clearAllImageSelect()
    }, [])

    return (
        <div className='grid wide'>
            <DynamicModal showModal={Boolean(selectViewImageUrl)}>
                <TabContainer
                    onClickOutside={() => {
                        setSelectViewImageUrl('')
                    }}
                >
                    <img src={selectViewImageUrl} alt='preview' />
                </TabContainer>
            </DynamicModal>
            <Container className='mt--7' fluid>
                <Row noGutters={true}>
                    <Col className='order-xl-2 mb-5 mb-xl-0' xl='4'>
                        <div className={clsx(styles.sideBar, 'shadow')}>
                            <div className={styles.wrap}>
                                <div className={styles.title}>Message</div>
                                {/* <FiEdit className={styles.addUserIcon} /> */}
                                <div className={styles.searchInput}>
                                    <Input
                                        className={clsx(
                                            'form-control-alternative'
                                        )}
                                        id='input-address'
                                        placeholder='Search ...'
                                        type='text'
                                    />
                                </div>
                            </div>
                            <div className={styles.listUser}>
                                <div className={styles.user}>
                                    <img
                                        src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                        alt='avatar'
                                        width={50}
                                        height={50}
                                        className={styles.avatar}
                                    />
                                    <div className={styles.userInfo}>
                                        <div className={styles.name}>
                                            Nguyễn Trọng Trí
                                        </div>
                                        <div className={styles.lastMessage}>
                                            Lorem ipsum dolor sit amet.
                                        </div>
                                    </div>
                                    <div className={styles.moreInfo}>
                                        <div className={styles.lastMessageTime}>
                                            10:30 PM
                                        </div>
                                        <div className={styles.unRead}>2</div>
                                    </div>
                                </div>
                                <div
                                    className={clsx(styles.user, styles.active)}
                                >
                                    <img
                                        src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                        alt='avatar'
                                        width={50}
                                        height={50}
                                        className={styles.avatar}
                                    />
                                    <div className={styles.userInfo}>
                                        <div className={styles.name}>
                                            Nguyễn Trọng Trí
                                        </div>
                                        <div className={styles.lastMessage}>
                                            Lorem ipsum dolor sit amet.
                                        </div>
                                    </div>
                                    <div className={styles.moreInfo}>
                                        <div className={styles.lastMessageTime}>
                                            10:30 PM
                                        </div>
                                        <div className={styles.unRead}>2</div>
                                    </div>
                                </div>
                                <div className={clsx(styles.user)}>
                                    <img
                                        src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                        alt='avatar'
                                        width={50}
                                        height={50}
                                        className={styles.avatar}
                                    />
                                    <div className={styles.userInfo}>
                                        <div className={styles.name}>
                                            Nguyễn Trọng Trí
                                        </div>
                                        <div className={styles.lastMessage}>
                                            Lorem ipsum dolor sit amet.
                                        </div>
                                    </div>
                                    <div className={styles.moreInfo}>
                                        <div className={styles.lastMessageTime}>
                                            10:30 PM
                                        </div>
                                        <div className={styles.unRead}>2</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </Col>
                    <Col className='order-xl-1' xl='8'>
                        <div
                            className={clsx(
                                styles.conversationContainer,
                                'shadow'
                            )}
                        >
                            <div className={styles.selectedUserInfo}>
                                <img
                                    className={styles.selectedUserAvatar}
                                    src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                    alt='avatar'
                                    width={50}
                                    height={50}
                                />
                                <div className={styles.selectedUserName}>
                                    Nguyễn Trọng Trí
                                </div>
                            </div>
                            <div
                                className={clsx(styles.conversation, {
                                    [styles.haveImage]: listPreviewImage.length,
                                })}
                                ref={conversationRef}
                            >
                                <div className={styles.message}>
                                    <div className={styles.text}>
                                        Lorem ipsum dolor sit amet.
                                    </div>
                                    <div className={styles.time}>9:30 PM</div>
                                </div>
                                <div
                                    className={clsx(
                                        styles.message,
                                        styles.owner
                                    )}
                                >
                                    <div className={styles.text}>
                                        Lorem ipsum dolor sit amet consectetur
                                        adipisicing elit. Quam voluptatum illo
                                        ullam nesciunt deserunt ab a praesentium
                                        veniam odio minima.
                                    </div>
                                    <div className={styles.time}>9:30 PM</div>
                                </div>
                                <div
                                    className={clsx(
                                        styles.message,
                                        styles.owner
                                    )}
                                >
                                    <img
                                        src='https://scontent.fsgn5-2.fna.fbcdn.net/v/t1.15752-9/280501381_399839762044038_9120434923984635432_n.png?_nc_cat=110&ccb=1-7&_nc_sid=ae9488&_nc_ohc=QRaBJxi6zcEAX_YSp1B&_nc_ht=scontent.fsgn5-2.fna&oh=03_AVLGY9dDfp69WiIs9PPmBtIP8nQ9zQ4mp0pqnwNvxIfxLA&oe=62BF95FF'
                                        alt='avatar'
                                        style={{
                                            maxWidth: 500,
                                            maxHeight: 200,
                                            borderRadius: 20,
                                            cursor: 'pointer',
                                        }}
                                        onClick={() =>
                                            setSelectViewImageUrl(
                                                'https://scontent.fsgn5-2.fna.fbcdn.net/v/t1.15752-9/280501381_399839762044038_9120434923984635432_n.png?_nc_cat=110&ccb=1-7&_nc_sid=ae9488&_nc_ohc=QRaBJxi6zcEAX_YSp1B&_nc_ht=scontent.fsgn5-2.fna&oh=03_AVLGY9dDfp69WiIs9PPmBtIP8nQ9zQ4mp0pqnwNvxIfxLA&oe=62BF95FF'
                                            )
                                        }
                                    />
                                    <div className={styles.time}>9:30 PM</div>
                                </div>
                            </div>
                            <div className={styles.chatInputContainer}>
                                <div className={styles.wrapChatInput}>
                                    <div className={styles.listImageUpload}>
                                        {listPreviewImage.map(
                                            (
                                                { url, indexInFileData },
                                                index
                                            ) => (
                                                <div
                                                    className={
                                                        styles.imageUploadWrapper
                                                    }
                                                    key={indexInFileData}
                                                >
                                                    <img
                                                        src={url}
                                                        alt='img'
                                                        width={50}
                                                        height={50}
                                                        className={
                                                            styles.imageUpload
                                                        }
                                                    />
                                                    <TiDeleteOutline
                                                        className={
                                                            styles.deleteImageUpload
                                                        }
                                                        onClick={() =>
                                                            deleteFile(
                                                                'image',
                                                                index,
                                                                indexInFileData
                                                            )
                                                        }
                                                    />
                                                </div>
                                            )
                                        )}
                                        {listPreviewImage.length === 0 ? (
                                            ''
                                        ) : (
                                            <label
                                                htmlFor='imageMessage'
                                                className={styles.addNewImage}
                                            >
                                                <span
                                                    className={
                                                        styles.addImageIcon
                                                    }
                                                ></span>
                                            </label>
                                        )}
                                    </div>
                                    <input
                                        className={clsx(styles.chatInput)}
                                        placeholder='Text here ...'
                                        type='text'
                                        value={textMessage}
                                        onChange={e =>
                                            setTextMessage(e.target.value)
                                        }
                                    />
                                </div>
                                <input
                                    type='file'
                                    id='imageMessage'
                                    hidden
                                    onChange={handleSelectMediaFile}
                                />
                                <label
                                    htmlFor='imageMessage'
                                    className={styles.attach}
                                >
                                    <ImAttachment />
                                </label>
                                {/* <div className={styles.line}></div> */}
                                <IoIosSend className={styles.sendMessage} />
                            </div>
                        </div>
                    </Col>
                </Row>
            </Container>
        </div>
    )
}

export default Chat
