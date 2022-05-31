import Frame from '../../Common/Frame/Frame'
import styles from './profileuser.module.css'
import { FaUserCircle } from 'react-icons/fa'
import { AiOutlineStar, AiOutlinePhone } from 'react-icons/ai'
import { IoLocationOutline } from 'react-icons/io5'
import HorizontalPost from '../../Common/ListPost/Post/HorizontalPost'
import { useNavigate, useParams } from 'react-router-dom'
import { useDispatch, useSelector } from 'react-redux'
import { selectNumberPhone } from '../../features/Auth/Login/loginSlice'
import { useEffect } from 'react'
import {
    selectPendingState,
    selectUserInfo,
    selectUserPost,
} from '../../features/User/UserSlice'
import TimeAgo from 'javascript-time-ago'
import clsx from 'clsx'
import DynamicModal from '../../Common/DynamicModal/DynamicModal'

const imgSrc = process.env.REACT_APP_BASE_IMG_URL

function ProfileUser(props) {
    const timeAgo = new TimeAgo('en-US')
    const { profileUserNumberPhone } = useParams()
    const loginUserNumberPhone = useSelector(selectNumberPhone)
    const userProfile = useSelector(selectUserInfo)
    const userPost = useSelector(selectUserPost)
    const dispatch = useDispatch()
    const navigate = useNavigate()
    const isLoading = useSelector(selectPendingState)
    console.log(profileUserNumberPhone)
    console.log(loginUserNumberPhone)

    useEffect(() => {
        dispatch({ type: 'getProfile', sdt: profileUserNumberPhone })
    }, [profileUserNumberPhone])
    console.log(userProfile)
    return (
        <div className='grid wide'>
            <DynamicModal showModal={isLoading} loading />
            <Frame>
                <div className={styles.userInfoContainer}>
                    <div className={styles.userInfo}>
                        {userProfile.anhDaiDienSource ? (
                            <img
                                src={imgSrc + userProfile.anhDaiDienSource}
                                alt='avatar'
                                width={100}
                                height={100}
                                className={styles.avatar}
                            />
                        ) : (
                            <FaUserCircle className={styles.icon} />
                        )}

                        <div className={styles.info}>
                            <div className={styles.name}>{userProfile.ten}</div>
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
                                {userProfile.danhGiaHeThong}
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
                                Ngày tham gia:
                            </span>
                            <span style={{ fontWeight: 500 }}>
                                {/* {userProfile.createdDate &&
                                    timeAgo(userProfile.createdDate)} */}
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
                                {userProfile.diaChi}
                            </span>
                        </div>
                        <div className={styles.infoItem}>
                            <span className={styles.label}>
                                <AiOutlinePhone
                                    style={{
                                        fontSize: 20,
                                        position: 'relative',
                                        top: 5,
                                        marginRight: 8,
                                    }}
                                />
                                Số điện thoại
                            </span>
                            <span style={{ fontWeight: 500 }}>
                                {userProfile.soDienThoai}
                            </span>
                        </div>
                        {profileUserNumberPhone === loginUserNumberPhone ? (
                            <button
                                className={clsx(styles.savePost, styles.small)}
                                onClick={() =>
                                    navigate(
                                        `/user/edit-profile/${profileUserNumberPhone}`
                                    )
                                }
                            >
                                Chỉnh sửa thông tin
                            </button>
                        ) : (
                            ''
                        )}
                    </div>
                </div>
            </Frame>
            <Frame title={'Tin đang đăng'}>
                {userPost.map(
                    (tieuDe, idHinhAnh, gia, ngayTao, thanhPho, idBaiDang) => (
                        <HorizontalPost
                            key={idBaiDang}
                            idPost={idBaiDang}
                            title={tieuDe}
                            price={gia}
                            imgId={idHinhAnh}
                            location={thanhPho}
                            createdDate={ngayTao}
                            isMyPost={
                                loginUserNumberPhone === profileUserNumberPhone
                            }
                        />
                    )
                )}
            </Frame>
        </div>
    )
}

export default ProfileUser
