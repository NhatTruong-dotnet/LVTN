import styles from './notification.module.css'
import { BsFillBellFill } from 'react-icons/bs'
import { useState } from 'react'
import TabContainer from '../../../../Common/TabContainer'

function Notification(props) {
    const [isShowNotificationTab, setIsShowNotificationTab] = useState(false)

    return (
        <span className={styles.wrap}>
            <BsFillBellFill
                className={styles.userIcon}
                onClick={() => setIsShowNotificationTab(true)}
            />
            {isShowNotificationTab && (
                <TabContainer
                    onClickOutside={() => setIsShowNotificationTab(false)}
                >
                    <div className={styles.notifyTab}>
                        <div className={styles.notifyItem}>
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
                        </div>
                        <div className={styles.notifyItem}>
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
                        </div>
                    </div>
                </TabContainer>
            )}
        </span>
    )
}

export default Notification
