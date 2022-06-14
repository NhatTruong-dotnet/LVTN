import styles from '../chat.module.css'
import clsx from 'clsx'
import { Input } from 'reactstrap'
import { useSelector, useDispatch } from 'react-redux'
import { selectReceiveUserSdt } from '../../../features/Chat/ChatSlice'
import { useEffect } from 'react'
import { selectNumberPhone } from '../../../features/Auth/Login/loginSlice'

function ListConversation({
    listConversation,
    receiveUserInfo,
    handleSelectConversation,
}) {
    const receiveUserSdt = useSelector(selectReceiveUserSdt)
    const loginUserSdt = useSelector(selectNumberPhone)
    const dispatch = useDispatch()

    useEffect(() => {
        if (loginUserSdt) {
            dispatch({ type: 'getAllConversation' })
        }
    }, [loginUserSdt])

    return (
        <div className={clsx(styles.sideBar, 'shadow')}>
            <div className={styles.wrap}>
                <div className={styles.title}>Message</div>
                {/* <FiEdit className={styles.addUserIcon} /> */}
                <div className={styles.searchInput}>
                    <Input
                        className={clsx('form-control-alternative')}
                        id='input-address'
                        placeholder='Search ...'
                        type='text'
                    />
                </div>
            </div>
            <div className={styles.listUser}>
                {listConversation.map(
                    ({
                        conversationId,
                        sdtNguoiBan,
                        sdtNguoiMua,
                        imageSourceNguoiBan,
                        imageSourceNguoiMua,
                        lastMessage,
                        time,
                    }) => (
                        <div
                            className={clsx(styles.user, {
                                [styles.active]: receiveUserSdt === sdtNguoiMua,
                            })}
                            key={conversationId}
                            onClick={() => {
                                console.log('click')
                                handleSelectConversation({
                                    id: conversationId,
                                    ten: sdtNguoiMua,
                                    soDienThoai: sdtNguoiMua,
                                    anhDaiDienSource: imageSourceNguoiMua,
                                })
                            }}
                        >
                            <img
                                src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                                alt='avatar'
                                width={50}
                                height={50}
                                className={styles.avatar}
                            />
                            <div className={styles.userInfo}>
                                <div className={styles.name}>{sdtNguoiMua}</div>
                                <div className={styles.lastMessage}>
                                    {lastMessage}
                                </div>
                            </div>
                            <div className={styles.moreInfo}>
                                <div className={styles.lastMessageTime}>
                                    {time}
                                </div>
                                <div className={styles.unRead}>2</div>
                            </div>
                        </div>
                    )
                )}

                {/* <div className={clsx(styles.user, styles.active)}>
                    <img
                        src='https://i.pinimg.com/236x/23/31/03/233103d32c9696866e2dda84e4ec983a.jpg'
                        alt='avatar'
                        width={50}
                        height={50}
                        className={styles.avatar}
                    />
                    <div className={styles.userInfo}>
                        <div className={styles.name}>{receiveUserInfo.ten}</div>
                        <div className={styles.lastMessage}>
                            Lorem ipsum dolor sit amet.
                        </div>
                    </div>
                    <div className={styles.moreInfo}>
                        <div className={styles.lastMessageTime}>10:30 PM</div>
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
                        <div className={styles.name}>Nguyễn Trọng Trí</div>
                        <div className={styles.lastMessage}>
                            Lorem ipsum dolor sit amet.
                        </div>
                    </div>
                    <div className={styles.moreInfo}>
                        <div className={styles.lastMessageTime}>10:30 PM</div>
                        <div className={styles.unRead}>2</div>
                    </div>
                </div> */}
            </div>
        </div>
    )
}

export default ListConversation
