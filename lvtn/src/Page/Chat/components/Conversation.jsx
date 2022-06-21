import styles from '../chat.module.css'
import clsx from 'clsx'
import { useRef, useEffect, useState } from 'react'
import DynamicModal from '../../../Common/DynamicModal/DynamicModal'
import TabContainer from '../../../Common/TabContainer'
import { useSelector } from 'react-redux'
import { selectListMessage } from '../../../features/Chat/ChatSlice'
import Message from './Message'
import { nanoid } from '@reduxjs/toolkit'

function Conversation({ listPreviewImage, deleteFile }) {
    const [selectViewImageUrl, setSelectViewImageUrl] = useState('')
    const listMessage = useSelector(selectListMessage)
    const conversationRef = useRef()

    useEffect(() => {}, [])

    useEffect(() => {
        conversationRef.current.scrollTop = conversationRef.current.scrollHeight
    })

    return (
        <>
            <DynamicModal showModal={Boolean(selectViewImageUrl)}>
                <TabContainer
                    onClickOutside={() => {
                        setSelectViewImageUrl('')
                    }}
                >
                    <img src={selectViewImageUrl} alt='preview' height={600} />
                </TabContainer>
            </DynamicModal>
            <div
                className={clsx(styles.conversation, {
                    [styles.haveImage]: listPreviewImage.length,
                })}
                ref={conversationRef}
            >
                {listMessage.map(
                    ({
                        messagesBy,
                        messagesTo,
                        time,
                        messageText,
                        messageImageSource,
                    }) => (
                        <Message
                            key={nanoid()}
                            messagesBy={messagesBy}
                            // time={time}
                            messageText={messageText}
                            messageImageSource={messageImageSource}
                            setSelectViewImageUrl={setSelectViewImageUrl}
                        />
                    )
                )}
                {/* <div className={styles.message}>
                    <div className={styles.text}>
                        Lorem ipsum dolor sit amet.
                    </div>
                    <div className={styles.time}>9:30 PM</div>
                </div>
                <div className={clsx(styles.message, styles.owner)}>
                    <div className={styles.text}>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        Quam voluptatum illo ullam nesciunt deserunt ab a
                        praesentium veniam odio minima.
                    </div>
                    <div className={styles.time}>9:30 PM</div>
                </div>
                <div className={clsx(styles.message, styles.owner)}>
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
                </div> */}
            </div>
        </>
    )
}

export default Conversation
