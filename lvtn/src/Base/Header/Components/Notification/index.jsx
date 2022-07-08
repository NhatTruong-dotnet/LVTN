import styles from './notification.module.css'
import { BsFillBellFill } from 'react-icons/bs'
import { useEffect, useState } from 'react'
import TabContainer from '../../../../Common/TabContainer'
import { selectListNotify } from '../../../../features/Notify/NotifySlice'
import { useDispatch, useSelector } from 'react-redux'
import { selectNumberPhone } from '../../../../features/Auth/Login/loginSlice'
import { useNavigate } from 'react-router-dom'

const imgURL = process.env.REACT_APP_BASE_IMG_URL

function Notification(props) {
    const [isShowNotificationTab, setIsShowNotificationTab] = useState(false)
    const listNotification = useSelector(selectListNotify)
    const sdt = useSelector(selectNumberPhone)
    const dispatch = useDispatch()
    const navigate = useNavigate()

    function uncheckedCounter() {
        const uncheckedNotification = listNotification.filter(
            ({ checked }) => !checked
        )
        return uncheckedNotification.length
    }

    useEffect(() => {
        if (sdt) {
            dispatch({ type: 'getAllNotify' })
        }
    }, [sdt])

    return (
        <span className={styles.wrap}>
            <span style={{ position: 'relative' }}>
                <BsFillBellFill
                    className={styles.userIcon}
                    onClick={() => setIsShowNotificationTab(true)}
                />
                {uncheckedCounter() === 0 ? (
                    ''
                ) : (
                    <span className={styles.unChecked}>
                        {uncheckedCounter()}
                    </span>
                )}
            </span>
            {isShowNotificationTab && (
                <TabContainer
                    onClickOutside={() => setIsShowNotificationTab(false)}
                >
                    <div className={styles.notifyTab}>
                        {listNotification.map(
                            ({
                                tieuDeThongBao,
                                imageSource,
                                idPost,
                                checked,
                                mota,
                            }) => (
                                <div
                                    className={styles.notifyItem}
                                    key={idPost}
                                    onClick={() =>
                                        navigate(`/detail/${idPost}`)
                                    }
                                >
                                    <img
                                        src={`${imgURL}${imageSource}`}
                                        alt='notifyImage'
                                        className={styles.notifyImage}
                                    />
                                    <div className={styles.notifyContent}>
                                        <div className={styles.title}>
                                            {tieuDeThongBao}
                                        </div>
                                        <div className={styles.subTitle}>
                                            {mota}
                                        </div>
                                        {!checked ? (
                                            ''
                                        ) : (
                                            <div className={styles.isApprove}>
                                                *Bài viết đã được phê duyệt
                                            </div>
                                        )}
                                    </div>
                                </div>
                            )
                        )}
                        {/* <div className={styles.notifyItem}>
                            <img
                                src='https://cdn.chotot.com/8QJGbVOGINr03Uh3STwGBKf9Dp0YU2fYfKPX2LZ-5Oc/preset:listing/plain/d1a1938227445eecfe5b6929a1d6b734-2771052330592886927.jpg'
                                alt='notifyImage'
                                className={styles.notifyImage}
                            />
                            <div className={styles.notifyContent}>
                                <div className={styles.title}>
                                    Lorem, ipsum dolor.
                                </div>
                                <div className={styles.subTitle}>
                                    Lorem ipsum dolor sit amet consectetur
                                    adipisicing elit. Soluta, molestias deleniti
                                    doloribus assumenda ipsam laboriosam! At
                                    voluptate illo tempore enim.
                                </div>
                                <div className={styles.timeAgo}>
                                    18 giờ trước
                                </div>
                            </div>
                        </div> */}
                    </div>
                </TabContainer>
            )}
        </span>
    )
}

export default Notification
