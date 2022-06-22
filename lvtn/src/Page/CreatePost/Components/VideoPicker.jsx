import styles from '../createpost.module.css'
import clsx from 'clsx'
import { nanoid } from '@reduxjs/toolkit'
import { FaTimesCircle } from 'react-icons/fa'

function VideoPicker({ listPreviewVideo, deleteFile }) {
    return (
        <>
            {listPreviewVideo.length ? (
                <div className={styles.previewImageContainer}>
                    <label
                        htmlFor='filePicker'
                        className={clsx(styles.imagePicker, styles.small)}
                    >
                        <svg
                            xmlns='http://www.w3.org/2000/svg'
                            width='53'
                            height='39'
                            viewBox='0 0 53 39'
                        >
                            <path
                                fill='#fff'
                                stroke='#FE9900'
                                strokeWidth={2}
                                d='M39.62 11.031l.013-.006.012-.006 11.707-6.042a1.329 1.329 0 01.208-.076l.007.003.128.025c.28.054.305.221.305.228v26.046a.412.412 0 01-.07.095.704.704 0 01-.203.145h-.122c-.073 0-.126 0-.176-.002h-.024l-.031-.017-11.721-6.183-.016-.008-.017-.008c-.16-.077-.41-.363-.41-.847v-12.5c0-.484.25-.77.41-.847zm11.716 20.404h.001-.001z'
                            ></path>
                            <mask id='path-2-inside-1_289_1913' fill='#fff'>
                                <path
                                    fillRule='evenodd'
                                    d='M10.447 7c1.81 0 3.234 1.466 3.234 3.333 0 1.867-1.423 3.333-3.234 3.333S7.213 12.2 7.213 10.333C7.213 8.466 8.636 7 10.447 7zM28.07 36.167c4.656 0 8.537-4 8.537-8.8v-18.4c0-4.8-3.88-8.8-8.537-8.8H8.537C3.881.167 0 4.167 0 8.967v18.4c0 4.934 3.751 8.8 8.537 8.8H28.07z'
                                    clipRule='evenodd'
                                ></path>
                            </mask>
                            <path
                                fill='#FE9900'
                                d='M10.447 9c.65 0 1.234.513 1.234 1.333h4C15.68 7.419 13.419 5 10.447 5v4zm1.234 1.333c0 .82-.584 1.333-1.234 1.333v4c2.972 0 5.234-2.42 5.234-5.333h-4zm-1.234 1.333c-.65 0-1.234-.513-1.234-1.333h-4c0 2.914 2.262 5.333 5.234 5.333v-4zm-1.234-1.333c0-.82.584-1.333 1.234-1.333V5c-2.972 0-5.234 2.42-5.234 5.333h4zM28.07 38.167c5.818 0 10.537-4.953 10.537-10.8h-4c0 3.753-3.042 6.8-6.537 6.8v4zm10.537-10.8v-18.4h-4v18.4h4zm0-18.4c0-5.847-4.72-10.8-10.537-10.8v4c3.495 0 6.537 3.047 6.537 6.8h4zM28.07-1.833H8.537v4H28.07v-4zm-19.533 0C2.72-1.833-2 3.12-2 8.967h4c0-3.753 3.042-6.8 6.537-6.8v-4zM-2 8.967v18.4h4v-18.4h-4zm0 18.4c0 5.98 4.59 10.8 10.537 10.8v-4c-3.624 0-6.537-2.913-6.537-6.8h-4zm10.537 10.8H28.07v-4H8.537v4z'
                                mask='url(#path-2-inside-1_289_1913)'
                            ></path>
                        </svg>
                    </label>

                    {listPreviewVideo.map((url, index) => (
                        <div
                            key={nanoid()}
                            className={clsx(styles.imageItem, styles.small)}
                        >
                            <FaTimesCircle
                                className={styles.deleteImageIcon}
                                onClick={() => deleteFile('video', index)}
                            />
                            <video
                                src={url}
                                style={{
                                    width: '100%',
                                    height: 80,
                                }}
                            ></video>
                        </div>
                    ))}
                </div>
            ) : (
                <label htmlFor='filePicker' className={styles.videoPicker}>
                    <svg
                        xmlns='http://www.w3.org/2000/svg'
                        width='53'
                        height='39'
                        viewBox='0 0 53 39'
                    >
                        <path
                            fill='#fff'
                            stroke='#FE9900'
                            strokeWidth={2}
                            d='M39.62 11.031l.013-.006.012-.006 11.707-6.042a1.329 1.329 0 01.208-.076l.007.003.128.025c.28.054.305.221.305.228v26.046a.412.412 0 01-.07.095.704.704 0 01-.203.145h-.122c-.073 0-.126 0-.176-.002h-.024l-.031-.017-11.721-6.183-.016-.008-.017-.008c-.16-.077-.41-.363-.41-.847v-12.5c0-.484.25-.77.41-.847zm11.716 20.404h.001-.001z'
                        ></path>
                        <mask id='path-2-inside-1_289_1913' fill='#fff'>
                            <path
                                fillRule='evenodd'
                                d='M10.447 7c1.81 0 3.234 1.466 3.234 3.333 0 1.867-1.423 3.333-3.234 3.333S7.213 12.2 7.213 10.333C7.213 8.466 8.636 7 10.447 7zM28.07 36.167c4.656 0 8.537-4 8.537-8.8v-18.4c0-4.8-3.88-8.8-8.537-8.8H8.537C3.881.167 0 4.167 0 8.967v18.4c0 4.934 3.751 8.8 8.537 8.8H28.07z'
                                clipRule='evenodd'
                            ></path>
                        </mask>
                        <path
                            fill='#FE9900'
                            d='M10.447 9c.65 0 1.234.513 1.234 1.333h4C15.68 7.419 13.419 5 10.447 5v4zm1.234 1.333c0 .82-.584 1.333-1.234 1.333v4c2.972 0 5.234-2.42 5.234-5.333h-4zm-1.234 1.333c-.65 0-1.234-.513-1.234-1.333h-4c0 2.914 2.262 5.333 5.234 5.333v-4zm-1.234-1.333c0-.82.584-1.333 1.234-1.333V5c-2.972 0-5.234 2.42-5.234 5.333h4zM28.07 38.167c5.818 0 10.537-4.953 10.537-10.8h-4c0 3.753-3.042 6.8-6.537 6.8v4zm10.537-10.8v-18.4h-4v18.4h4zm0-18.4c0-5.847-4.72-10.8-10.537-10.8v4c3.495 0 6.537 3.047 6.537 6.8h4zM28.07-1.833H8.537v4H28.07v-4zm-19.533 0C2.72-1.833-2 3.12-2 8.967h4c0-3.753 3.042-6.8 6.537-6.8v-4zM-2 8.967v18.4h4v-18.4h-4zm0 18.4c0 5.98 4.59 10.8 10.537 10.8v-4c-3.624 0-6.537-2.913-6.537-6.8h-4zm10.537 10.8H28.07v-4H8.537v4z'
                            mask='url(#path-2-inside-1_289_1913)'
                        ></path>
                    </svg>
                    <div className={styles.text}>Đăng tối đa 1 video</div>
                </label>
            )}
        </>
    )
}

export default VideoPicker
