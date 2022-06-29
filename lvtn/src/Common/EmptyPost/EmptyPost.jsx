import styles from './emptypost.module.css'

function EmptyPost({ height }) {
    return (
        <div className={styles.container} style={{ height }}>
            <div className={styles.text}>Không tìm thấy bài đăng nào</div>
        </div>
    )
}

export default EmptyPost
