import styles from '../chat.module.css'
import clsx from 'clsx'
import { useSelector } from 'react-redux'
import { selectNumberPhone } from '../../../features/Auth/Login/loginSlice'
const imgURL = process.env.REACT_APP_BASE_IMG_URL

function Message({
    messagesBy,
    time,
    messageText,
    messageImageSource,
    setSelectViewImageUrl,
}) {
    const loginUserSdt = useSelector(selectNumberPhone)

    if (messageText && !messageImageSource) {
        return (
            <MessageText
                messagesBy={messagesBy}
                messageText={messageText}
                time={time}
                setSelectViewImageUrl={setSelectViewImageUrl}
                loginUserSdt={loginUserSdt}
            />
        )
    } else if (!messageText && messageImageSource) {
        return (
            <MessageImage
                messagesBy={messagesBy}
                messageImageSource={messageImageSource}
                time={time}
                setSelectViewImageUrl={setSelectViewImageUrl}
                loginUserSdt={loginUserSdt}
            />
        )
    } else {
        return (
            <>
                <MessageText
                    messagesBy={messagesBy}
                    messageText={messageText}
                    time={time}
                    setSelectViewImageUrl={setSelectViewImageUrl}
                    loginUserSdt={loginUserSdt}
                />
                <MessageImage
                    messagesBy={messagesBy}
                    messageImageSource={messageImageSource}
                    time={time}
                    setSelectViewImageUrl={setSelectViewImageUrl}
                    loginUserSdt={loginUserSdt}
                />
            </>
        )
    }

    // return (
    //     <>
    //         {type === 'text' ? (
    //             <MessageText
    //                 messagesBy={messagesBy}
    //                 messageText={messageText}
    //                 time={time}
    //                 setSelectViewImageUrl={setSelectViewImageUrl}
    //                 loginUserSdt={loginUserSdt}
    //             />
    //         ) : (
    //             <MessageImage
    //                 messagesBy={messagesBy}
    //                 messageImageSource={messageImageSource}
    //                 time={time}
    //                 setSelectViewImageUrl={setSelectViewImageUrl}
    //                 loginUserSdt={loginUserSdt}
    //             />
    //         )}
    //     </>
    // )
}

export default Message

function MessageText({ messagesBy, messageText, time, loginUserSdt }) {
    return (
        <div
            className={clsx(styles.message, {
                [styles.owner]: messagesBy === loginUserSdt,
            })}
        >
            <div className={styles.text}>{messageText}</div>
            <div className={styles.time}>{time}</div>
        </div>
    )
}

function MessageImage({
    messagesBy,
    time,
    messageImageSource,
    setSelectViewImageUrl,
    loginUserSdt,
}) {
    return (
        <div
            className={clsx(styles.message, {
                [styles.owner]: messagesBy === loginUserSdt,
            })}
        >
            <img
                // src='https://scontent.fsgn5-2.fna.fbcdn.net/v/t1.15752-9/280501381_399839762044038_9120434923984635432_n.png?_nc_cat=110&ccb=1-7&_nc_sid=ae9488&_nc_ohc=QRaBJxi6zcEAX_YSp1B&_nc_ht=scontent.fsgn5-2.fna&oh=03_AVLGY9dDfp69WiIs9PPmBtIP8nQ9zQ4mp0pqnwNvxIfxLA&oe=62BF95FF'
                src={`${imgURL}${messageImageSource}`}
                alt='message'
                style={{
                    maxWidth: 500,
                    maxHeight: 200,
                    borderRadius: 20,
                    cursor: 'pointer',
                }}
                onClick={
                    () =>
                        setSelectViewImageUrl(`${imgURL}${messageImageSource}`)
                    // setSelectViewImageUrl(
                    //     'https://scontent.fsgn5-2.fna.fbcdn.net/v/t1.15752-9/280501381_399839762044038_9120434923984635432_n.png?_nc_cat=110&ccb=1-7&_nc_sid=ae9488&_nc_ohc=QRaBJxi6zcEAX_YSp1B&_nc_ht=scontent.fsgn5-2.fna&oh=03_AVLGY9dDfp69WiIs9PPmBtIP8nQ9zQ4mp0pqnwNvxIfxLA&oe=62BF95FF'
                    // )
                }
            />
            <div className={styles.time}>{time}</div>
        </div>
    )
}
