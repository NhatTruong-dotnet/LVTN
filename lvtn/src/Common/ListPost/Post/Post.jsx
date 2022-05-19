import clsx from 'clsx'
import styles from './post.module.css'
import { formatCurrency } from '../../../Utils/formatCurrency'
import { FaStore } from 'react-icons/fa'
import { useNavigate } from 'react-router-dom'

const imgURL = process.env.PUBLIC_URL

function Post({ id, title, imgId, gia, createdDate, location }) {
    const navigate = useNavigate()

    const handleNavigateDetailPage = () => {
        navigate(`/detail/${id}`)
    }

    return (
        <div className={styles.wrap} onClick={handleNavigateDetailPage}>
            <div className={styles.postItem}>
                <img
                    src={`${imgURL}/${imgId}`}
                    alt={title}
                    className={styles.postImg}
                />

                <div className={styles.name}>{title}</div>

                <div className={clsx(styles.price)}>{formatCurrency(gia)}</div>
                <div className={styles.moreInfo}>
                    <FaStore className={styles.icon} />
                    <div className={styles.dot}></div>
                    <div className={styles.time}>18 giờ trước</div>
                    <div className={styles.dot}></div>
                    <div className={styles.location}>{location}</div>
                </div>
            </div>
        </div>
    )
}

export default Post
