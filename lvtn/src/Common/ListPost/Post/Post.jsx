import clsx from 'clsx'
import styles from './post.module.css'
import { formatCurrency } from '../../../Utils/formatCurrency'
import { FaStore } from 'react-icons/fa'

function Post({
    id,
    imgSrc,
    title,

    price,
}) {
    return (
        <div className={styles.wrap}>
            <div className={styles.postItem}>
                <img src={imgSrc} alt={title} className={styles.postImg} />

                <div className={styles.name}>{title}</div>

                <div className={clsx(styles.price)}>
                    {formatCurrency(10000)}
                </div>
                <div className={styles.moreInfo}>
                    <FaStore className={styles.icon} />
                    <div className={styles.dot}></div>
                    <div className={styles.time}>18 giờ trước</div>
                    <div className={styles.dot}></div>
                    <div className={styles.location}>Đà Nẵng</div>
                </div>
            </div>
        </div>
    )
}

export default Post
