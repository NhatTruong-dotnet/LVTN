import React from 'react'
import { useParams } from 'react-router-dom'
import 'react-responsive-carousel/lib/styles/carousel.min.css'
import { Carousel } from 'react-responsive-carousel'
import styles from './detail.module.css'
import { FaRegHeart, FaUserCircle } from 'react-icons/fa'
import { GoLocation } from 'react-icons/go'
import Frame from '../../Common/Frame/Frame'
import ListPost from '../../Common/ListPost/ListPost'
import clsx from 'clsx'

const array = [
    {
        idBaiDang: 1,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 1,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 1,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
    {
        idBaiDang: 1,
        tieuDe: 'bai dang 1',
        idHinhAnh:
            'https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg',
        gia: 6,
        ngayTao: new Date(),
        thanhPho: 'hcm',
    },
]

function Detail(props) {
    const params = useParams()
    console.log(params)

    return (
        <div className='grid wide'>
            <Frame>
                <div className='row'>
                    <div className='col l-8'>
                        <Carousel infiniteLoop={true}>
                            <div>
                                <img src='https://cdn.chotot.com/i3Pu-GHom-VwJjFyuHMofKGQ3qmoB50vggUAdgiifr8/preset:view/plain/ead255d58d5fa3a16d7bfd199ccef858-2772334573435722045.jpg' />
                            </div>
                            <div>
                                <img src='https://cdn.chotot.com/wDhwB8UnRJIW3-hSafZC309nZvZu1ROnP57NXar0bZo/preset:view/plain/88bc6137e3970fe54b869df9212c9715-2772334569845266749.jpg' />
                            </div>
                            <div>
                                <img src='https://cdn.chotot.com/xjwkhUb5gwnTX0GE-eKx9KQlbiWLy7XaVXg9xGvqO3E/preset:view/plain/84a5bc5f3376ca291470115100af1766-2772334573301975305.jpg' />
                            </div>
                        </Carousel>

                        <div className={styles.detailContainer}>
                            <div className={styles.title}>bán xe</div>
                            <div className={styles.price}>8 tỷ</div>
                            <div className={styles.description}>
                                Lorem ipsum dolor sit amet consectetur,
                                adipisicing elit. Quia, aut?
                            </div>
                            <div className={styles.numberPhone}>
                                Liên hệ: 0123456789
                            </div>
                            <div className={styles.savePost}>
                                Lưu tin <FaRegHeart className={styles.icon} />
                            </div>

                            <div className={styles.detail}>
                                <div className={styles.detailItem}>
                                    Hãng: Maybach
                                </div>
                                <div className={styles.detailItem}>
                                    Dòng xe: Dòng khác
                                </div>
                                <div className={styles.detailItem}>
                                    Năm sản xuất: 2019
                                </div>
                                <div className={styles.detailItem}>
                                    Số Km đã đi: 20000
                                </div>
                            </div>
                            <div className={styles.subTitle}>Khu vực</div>
                            <div className={styles.address}>
                                <GoLocation className={styles.addressIcon} />
                                Phường Cầu Diễn, Quận Nam Từ Liêm, Hà Nội
                            </div>
                        </div>
                    </div>

                    <div className='col l-4'>
                        <div className={styles.vendorInfo}>
                            <div className={styles.avatar}>
                                <FaUserCircle />
                            </div>
                            <div className={styles.name}>Nguyễn Trọng Trí</div>
                            <div
                                className={clsx(styles.savePost, styles.small)}
                            >
                                Xem trang
                            </div>
                        </div>
                        <div className={styles.moreInfoVendor}>
                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                            <div className={styles.line}></div>
                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                            <div className={styles.line}></div>

                            <div className={styles.infoItem}>
                                <div className={styles.infoText}>Đánh giá</div>
                                <div className={styles.infoValue}>86%</div>
                            </div>
                        </div>
                    </div>
                </div>
            </Frame>
            <Frame title='Tin đăng tương tự'>
                <ListPost listPost={array} />
            </Frame>
        </div>
    )
}

export default Detail
