import styles from './loading.module.css'
import { AiOutlineLoading } from 'react-icons/ai'

function Loading(props) {
    return (
        <div className={styles.loaderContainer}>
            <AiOutlineLoading className={styles.icon} />
        </div>
    )
}

export default Loading
