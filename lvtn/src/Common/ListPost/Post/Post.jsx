import clsx from 'clsx'
import styles from './post.module.css'
import { formatCurrency } from '../../../Utils/formatCurrency'
import { FaStore } from 'react-icons/fa'
import { useNavigate } from 'react-router-dom'
import vi from 'javascript-time-ago/locale/vi.json'
import TimeAgo from 'javascript-time-ago'

const imgURL = process.env.REACT_APP_BASE_IMG_URL
TimeAgo.addDefaultLocale(vi)

function Post({ id, title, imgId, price, createdDate = new Date(), location }) {
    const navigate = useNavigate()

    const timeAgo = new TimeAgo('en-US')

    const handleNavigateDetailPage = () => {
        navigate(`/detail/${id}`)
        // navigate(`/detail/${2}`)
    }

    return (
        <div className={styles.wrap} onClick={handleNavigateDetailPage}>
            <div className={styles.postItem}>
                <img
                    src={`${imgURL}${imgId}`}
                    // src={imgId}
                    alt={title}
                    className={styles.postImg}
                />

                <div className={styles.name}>{title}</div>

                <div className={clsx(styles.price)}>
                    {formatCurrency(price)}
                </div>
                <div className={styles.moreInfo}>
                    <FaStore className={styles.icon} />
                    <div className={styles.dot}></div>
                    <div className={styles.time}>
                        {/* {createdDate && timeAgo.format(createdDate)} */}
                        {createdDate}
                    </div>
                    <div className={styles.dot}></div>
                    <div className={styles.location}>{location}</div>
                </div>
            </div>
        </div>
    )
}

export default Post
