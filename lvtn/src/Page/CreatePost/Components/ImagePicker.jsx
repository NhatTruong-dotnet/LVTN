import styles from '../createpost.module.css'
import clsx from 'clsx'
import { nanoid } from '@reduxjs/toolkit'
import { FaTimesCircle } from 'react-icons/fa'

function ImagePicker({
    listPreviewImage,
    deleteFile,
    multiple,
    bindingId,
    style,
    title,
}) {
    const renderPreviewImage = () => {
        return multiple ? (
            <div className={styles.previewImageContainer}>
                <label
                    htmlFor='filePicker'
                    className={clsx(styles.imagePicker, styles.small)}
                >
                    <svg
                        xmlns='http://www.w3.org/2000/svg'
                        width='24'
                        height='24'
                        viewBox='0 0 20 21'
                    >
                        <g
                            fill='none'
                            fillRule='evenodd'
                            stroke='none'
                            strokeWidth='1'
                        >
                            <g fill='#FE9900' transform='translate(-161 -428)'>
                                <g transform='translate(132 398)'>
                                    <g transform='translate(16.648 17.048)'>
                                        <g transform='rotate(-180 16.142 16.838)'>
                                            <rect
                                                width='2.643'
                                                height='19.82'
                                                x='8.588'
                                                y='0'
                                                rx='1.321'
                                            ></rect>
                                            <path
                                                d='M9.91 0c.73 0 1.321.592 1.321 1.321v17.177a1.321 1.321 0 01-2.643 0V1.321C8.588.591 9.18 0 9.91 0z'
                                                transform='rotate(90 9.91 9.91)'
                                            ></path>
                                        </g>
                                    </g>
                                </g>
                            </g>
                        </g>
                    </svg>
                </label>
                {listPreviewImage.map(({ url, indexInFileData }, index) => (
                    <div
                        key={nanoid()}
                        className={clsx(styles.imageItem, styles.small)}
                    >
                        <FaTimesCircle
                            className={styles.deleteImageIcon}
                            onClick={() =>
                                deleteFile('image', index, indexInFileData)
                            }
                        />
                        <img
                            src={url}
                            alt={index}
                            style={{
                                width: '100%',
                                height: 80,
                            }}
                        />
                        {!index ? (
                            <span className={styles.firstImage}>Hình bìa</span>
                        ) : (
                            ''
                        )}
                    </div>
                ))}
            </div>
        ) : (
            <label htmlFor='filePicker'>
                <img
                    width='350px'
                    height={'225px'}
                    src={listPreviewImage[0].url}
                    alt=''
                />
            </label>
        )
    }
    return (
        <>
            {listPreviewImage.length ? (
                renderPreviewImage()
            ) : (
                <label
                    htmlFor='filePicker'
                    className={styles.imagePicker}
                    style={style}
                >
                    <svg
                        xmlns='http://www.w3.org/2000/svg'
                        width='53'
                        height='39'
                        viewBox='0 0 53 39'
                    >
                        <g
                            fill='none'
                            fillRule='evenodd'
                            stroke='none'
                            strokeWidth='1'
                        >
                            <g
                                stroke='#FE9900'
                                strokeWidth='2'
                                transform='translate(-255 -179)'
                            >
                                <g transform='translate(132 122)'>
                                    <path d='M150.631 87.337c-5.755 0-10.42-4.534-10.42-10.127 0-5.593 4.665-10.127 10.42-10.127s10.42 4.534 10.42 10.127c0 5.593-4.665 10.127-10.42 10.127m10.42-24.755l-2.315-4.501h-16.21l-2.316 4.5h-11.579s-4.631 0-4.631 4.502v22.505c0 4.5 4.631 4.5 4.631 4.5h41.684s4.631 0 4.631-4.5V67.083c0-4.501-4.631-4.501-4.631-4.501h-9.263z'></path>
                                </g>
                            </g>
                        </g>
                    </svg>
                    <div className={styles.text}>
                        {title || 'Đăng từ 3 đến 10 hình'}
                    </div>
                </label>
            )}
        </>
    )
}

export default ImagePicker
