import styles from './loading.module.css'
import { AiOutlineLoading } from 'react-icons/ai'

function Loading({ height }) {
    return (
        <div className={styles.loaderContainer} style={{ height }}>
            <AiOutlineLoading className={styles.icon} />
        </div>
    )
}

export default Loading
