import Frame from '../../Common/Frame/Frame'
import styles from './profileuser.module.css'
import { FaUserCircle } from 'react-icons/fa'
import { AiOutlineStar } from 'react-icons/ai'
import { IoLocationOutline } from 'react-icons/io5'
import HorizontalPost from '../../Common/ListPost/Post/HorizontalPost'
import { useParams } from 'react-router-dom'
import { useSelector } from 'react-redux'
import { selectUsername } from '../../features/Auth/Login/loginSlice'

function ProfileUser(props) {
    const { profileUserNumberPhone } = useParams()
    const loginUserNumberPhone = useSelector(selectUsername)

    return (
        <div className='grid wide'>
            <Frame>
                <div className={styles.userInfoContainer}>
                    <div className={styles.userInfo}>
                        <FaUserCircle className={styles.icon} />
                        <div className={styles.info}>
                            <div className={styles.name}>Tri</div>
                            <div className={styles.follow}>
                                <div className={styles.followItem}>
                                    0 người theo dõi
                                </div>
                                <div className={styles.followItem}>
                                    0 đang theo dõi
                                </div>
                            </div>

                            {profileUserNumberPhone === loginUserNumberPhone ? (
                                ''
                            ) : (
                                <button className={styles.button}>
                                    Theo dõi
                                </button>
                            )}
                        </div>
                    </div>
                    <div className={styles.moreInfo}>
                        <div className={styles.infoItem}>
                            <span className={styles.label}>
                                <AiOutlineStar
                                    style={{
                                        fontSize: 20,
                                        position: 'relative',
                                        top: 5,
                                        marginRight: 8,
                                    }}
                                />
                                Đánh giá người dùng:
                            </span>
                            <span style={{ fontWeight: 500 }}>
                                Chưa có đánh giá
                            </span>
                        </div>
                        <div className={styles.infoItem}>
                            <span className={styles.label}>
                                <AiOutlineStar
                                    style={{
                                        fontSize: 20,
                                        position: 'relative',
                                        top: 5,
                                        marginRight: 8,
                                    }}
                                />
                                Đánh giá hệ thống:
                            </span>
                            <span style={{ fontWeight: 500 }}>
                                Chưa có đánh giá
                            </span>
                        </div>
                        <div className={styles.infoItem}>
                            <span className={styles.label}>
                                <IoLocationOutline
                                    style={{
                                        fontSize: 20,
                                        position: 'relative',
                                        top: 5,
                                        marginRight: 8,
                                    }}
                                />
                                Địa chỉ:
                            </span>
                            <span style={{ fontWeight: 500 }}>
                                Chưa có đánh giá
                            </span>
                        </div>
                    </div>
                </div>
            </Frame>
            <Frame title={'Tin đang đăng'}>
                <HorizontalPost
                    title={'test'}
                    price='20000000'
                    imgId={'1muzSn7Zdd2UuiW9dMJlzAuDtSRftI78z'}
                    location='quận 8, thành phố Hồ Chí Minh'
                    createdDate={new Date()}
                    isMyPost={loginUserNumberPhone === profileUserNumberPhone}
                />
                <HorizontalPost
                    title={'test'}
                    price='20000000'
                    imgId={'1muzSn7Zdd2UuiW9dMJlzAuDtSRftI78z'}
                    location='quận 8, thành phố Hồ Chí Minh'
                    createdDate={new Date()}
                    isMyPost={loginUserNumberPhone === profileUserNumberPhone}
                />
            </Frame>
        </div>
    )
}

export default ProfileUser
