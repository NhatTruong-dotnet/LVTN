import Frame from '../../Common/Frame/Frame'
import ListPost from '../../Common/ListPost/ListPost'
import styles from './home.module.css'

const listBook = [
    {
        _id: 1,
        title: 'item1',
        price: 20000,
        img: [
            'https://cdn.chotot.com/Q839gTdm_RZHqge03Gy-MgbqQ0WhUxfmQOtume0XOy4/preset:listing/plain/e88380e0852991afb10e590c6aa4c96f-2770726449161965901.jpg',
        ],
    },
    {
        _id: 2,
        title: 'item1',
        price: 20000,
        img: [
            'https://cdn.chotot.com/Q839gTdm_RZHqge03Gy-MgbqQ0WhUxfmQOtume0XOy4/preset:listing/plain/e88380e0852991afb10e590c6aa4c96f-2770726449161965901.jpg',
        ],
    },
    {
        _id: 3,
        title: 'item1',
        price: 20000,
        img: [
            'https://cdn.chotot.com/Q839gTdm_RZHqge03Gy-MgbqQ0WhUxfmQOtume0XOy4/preset:listing/plain/e88380e0852991afb10e590c6aa4c96f-2770726449161965901.jpg',
        ],
    },
    {
        _id: 4,
        title: 'item1',
        price: 20000,
        img: [
            'https://cdn.chotot.com/Q839gTdm_RZHqge03Gy-MgbqQ0WhUxfmQOtume0XOy4/preset:listing/plain/e88380e0852991afb10e590c6aa4c96f-2770726449161965901.jpg',
        ],
    },
]

function Home() {
    return (
        <div className='grid wide' style={{ marginTop: 90 }}>
            <Frame title='Khám phá danh mục'>
                <div className='row no-gutters'>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                    <div className='col l-2'>
                        <div className={styles.categoryItem}>
                            <img
                                src='https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95'
                                alt='cate'
                                className={styles.img}
                            />
                            Bất động sản
                        </div>
                    </div>
                </div>
            </Frame>
            <Frame title='Tin Dành cho bạn'>
                <ListPost listPost={listBook} />
            </Frame>
        </div>
    )
}

export default Home
