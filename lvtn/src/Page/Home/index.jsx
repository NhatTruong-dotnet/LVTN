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

const categories = [
    {
        id: 1,
        name: 'Bất động sản',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F1000.png&w=256&q=95',
    },
    {
        id: 2,
        name: 'Xe cộ',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F2000.png&w=256&q=95 1x',
    },
    {
        id: 3,
        name: 'Đồ điện tử',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F5000.png&w=256&q=95 1x',
    },
    {
        id: 4,
        name: 'Việc làm',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F13000.png&w=256&q=95 1x',
    },
    {
        id: 5,
        name: 'Thú cưng',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F12000.png&w=256&q=95 1x',
    },
    {
        id: 6,
        name: 'Đồ ăn, thực phẩm và các loại khác',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F7000.png&w=256&q=95 1x',
    },
    {
        id: 7,
        name: 'Tủ lạnh, máy lạnh, máy giặt',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F9000.png&w=256&q=95',
    },
    {
        id: 8,
        name: 'Đồ gia dụng, nội thất, cây cảnh',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F14000.png&w=256&q=95',
    },
    {
        id: 9,
        name: 'Mẹ và bé',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F11000.png&w=256&q=95',
    },
    {
        id: 10,
        name: 'Thời trang, Đồ dùng cá nhân',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F3000.png&w=256&q=95',
    },
    {
        id: 11,
        name: 'Giải trí, Thể thao, Sở thích',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F4000.png&w=256&q=95',
    },
    {
        id: 12,
        name: 'Đồ dùng văn phòng, công nông nghiệp',
        imgSrc: 'https://lighthouse.chotot.com/_next/image?url=https%3A%2F%2Fstatic.chotot.com%2Fstorage%2Fchapy-pro%2Fnewcats%2Fv8%2F8000.png&w=256&q=95',
    },
]

function Home() {
    return (
        <div className='grid wide'>
            <Frame title='Khám phá danh mục'>
                <div className='row no-gutters'>
                    {categories.map(({ id, name, imgSrc }) => (
                        <div className='col l-2' key={id}>
                            <div className={styles.categoryItem}>
                                <img
                                    src={imgSrc}
                                    alt={name}
                                    className={styles.img}
                                />
                                <span className={styles.name}>{name}</span>
                            </div>
                        </div>
                    ))}
                </div>
            </Frame>
            <Frame title='Tin Dành cho bạn'>
                <ListPost listPost={listBook} />
            </Frame>
        </div>
    )
}

export default Home
