import styles from './chatnotify.module.css'
import { useNavigate } from 'react-router-dom'
import { BsMessenger } from 'react-icons/bs'

function ChatNotify(props) {
    const navigate = useNavigate()
    return (
        <>
            <BsMessenger
                className={styles.userIcon}
                onClick={() => navigate('/chat')}
            />
        </>
    )
}

export default ChatNotify
