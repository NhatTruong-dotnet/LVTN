import { useEffect, useState } from 'react'
import { Col, Container, Row, Input } from 'reactstrap'
import styles from './chat.module.css'
import clsx from 'clsx'
// import { FiEdit } from 'react-icons/fi'

import { emitMessage } from '../../Common/ToastMessage/ToastMessage'
import { convertFile } from '../../Utils/PostUtils'

import { useDispatch, useSelector } from 'react-redux'
import { selectLoginStatus } from '../../features/Auth/Login/loginSlice'
import { useNavigate } from 'react-router-dom'
import {
    selectConversation,
    selectCurrentConversation,
    selectCurrentConversationId,
    selectListConversation,
    selectReceiveUserInfo,
    selectReceiveUserSdt,
    setCurrentConversationId,
    setReceiveUserInfo,
} from '../../features/Chat/ChatSlice'
import Conversation from './components/Conversation'
import ChatInput from './components/ChatInput'
import ListConversation from './components/ListConversation'
import { FaUserCircle } from 'react-icons/fa'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function Chat(props) {
    const [listPreviewImage, setListPreviewImage] = useState([])
    const [listFileDataMedia, setListFileDataMedia] = useState([])
    const isLogin = useSelector(selectLoginStatus)
    const navigate = useNavigate()
    const listConversation = useSelector(selectListConversation)
    const receiveUserInfo = useSelector(selectReceiveUserInfo)
    const receiveUserSdt = useSelector(selectReceiveUserSdt)
    const currentConversationId = useSelector(selectCurrentConversationId)
    const dispatch = useDispatch()

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
    const handleSelectConversation = ({
        id,
        ten,
        soDienThoai,
        anhDaiDienSource,
    }) => {
        dispatch(setCurrentConversationId(id))
        dispatch(
            setReceiveUserInfo({
                userInfo: {
                    ten,
                    soDienThoai,
                    anhDaiDienSource,
                },
            })
        )
    }

    // useEffect(() => {
    //     const currentConversationId = localStorage.getItem('lastConversation')
    //     if (currentConversationId && !receiveUserSdt) {
    //         // dispatch(setCurrentConversationId(currentConversationId))
    //         const receiveUser = listConversation.find(
    //             ({ conversationId }) =>
    //                 conversationId === +currentConversationId
    //         )
    //         if (receiveUser) {
    //             console.log('dispatch')
    //             dispatch(
    //                 setReceiveUserInfo({
    //                     userInfo: {
    //                         ten: receiveUser.ten,
    //                         soDienThoai: receiveUser.sdtNguoiMua,
    //                         anhDaiDienSource: receiveUser.imageSourceNguoiMua,
    //                     },
    //                 })
    //             )
    //         }
    //     } else if (!currentConversationId && !receiveUserSdt) {
    //         // dispatch(setCurrentConversationId(0))
    //     }
    // }, [listConversation])

    useEffect(() => {
        dispatch({ type: 'getAllConversation' })
    }, [])

    useEffect(() => {
        if (currentConversationId) {
            dispatch({ type: 'getAllMessage', id: currentConversationId })
        }
    }, [currentConversationId])

    useEffect(() => {
        clearAllImageSelect()
    }, [])

    useEffect(() => {
        if (!isLogin) {
            window.showLoginForm()
        }
    }, [])

    // useEffect(()=>{
    //     if(receiveUserInfo.soDienThoai){
    //         localStorage.setItem('lastChatUser', receiveUserInfo.soDienThoai)
    //     }else {
    //         const
    //     }
    // },[receiveUserInfo.soDienThoai])
    console.log(receiveUserInfo)
    return (
        <div className='grid wide'>
            <Container className='mt--7' fluid>
                <Row noGutters={true}>
                    <Col className='order-xl-2 mb-5 mb-xl-0' xl='4'>
                        <ListConversation
                            listConversation={listConversation}
                            receiveUserInfo={receiveUserInfo}
                            handleSelectConversation={handleSelectConversation}
                        />
                    </Col>
                    <Col className='order-xl-1' xl='8'>
                        <div
                            className={clsx(
                                styles.conversationContainer,
                                'shadow'
                            )}
                        >
                            <div className={styles.selectedUserInfo}>
                                {receiveUserInfo.anhDaiDienSource ? (
                                    <img
                                        className={styles.selectedUserAvatar}
                                        // src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                        src={`${imgURL}${receiveUserInfo.anhDaiDienSource}`}
                                        alt='avatar'
                                        width={50}
                                        height={50}
                                    />
                                ) : (
                                    <FaUserCircle
                                        style={{
                                            width: 50,
                                            height: 50,
                                            marginRight: 10,
                                        }}
                                    />
                                )}
                                <div className={styles.selectedUserName}>
                                    {receiveUserInfo.ten}
                                </div>
                            </div>
                            <Conversation
                                listPreviewImage={listPreviewImage}
                                deleteFile={deleteFile}
                            />
                            <ChatInput
                                listPreviewImage={listPreviewImage}
                                listFileDataMedia={listFileDataMedia}
                                handleSelectMediaFile={handleSelectMediaFile}
                                deleteFile={deleteFile}
                                deleteAllFile={clearAllImageSelect}
                            />
                        </div>
                    </Col>
                </Row>
            </Container>
        </div>
    )
}

export default Chat
