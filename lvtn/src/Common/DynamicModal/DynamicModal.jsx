import { useEffect, useRef, useState } from 'react'
import Modal from '../Modal/Modal'
import styles from './DynamicModal.module.css'
import { AiOutlineLoading, AiFillInfoCircle } from 'react-icons/ai'
import clsx from 'clsx'

function DynamicModal({
    showModal = true,
    autoClose,
    loading = false,
    confirmDialogConfig = null,
    children,
}) {
    const [isOpen, setIsOpen] = useState(showModal)
    let timer = useRef()
    useEffect(() => {
        if (autoClose && isOpen) {
            timer.current = setTimeout(() => {
                setIsOpen(false)
            }, autoClose)
        }
        return () => {
            clearTimeout(timer.current)
        }
    }, [autoClose, isOpen])

    useEffect(() => {
        setIsOpen(showModal)
    }, [showModal])

    let content

    if (loading) {
        content = <Loading />
    } else if (confirmDialogConfig) {
        content = <ConfirmDialog config={confirmDialogConfig} />
    } else {
        content = children
    }

    return <>{isOpen && <Modal>{content}</Modal>}</>
}

const Loading = () => {
    return (
        <div className={styles.loadingContainer}>
            <AiOutlineLoading className={styles.icon} />
            <div className={styles.text}>Loading...</div>
        </div>
    )
}

const ConfirmDialog = ({
    config: { title, content, acceptText, cancelText, onDone, loadingOnDone },
}) => {
    const [showLoading, setShowLoading] = useState(false)

    const onClickButton = value => {
        if (loadingOnDone) {
            setShowLoading(true)
        }
        onDone(value)
    }

    return (
        <>
            {showLoading ? (
                <Loading />
            ) : (
                <div className={styles.confirmContainer}>
                    <div className={styles.title}>
                        <AiFillInfoCircle className={styles.confirmIcon} />
                        {title}
                    </div>
                    <div className={styles.content}>
                        {Array.isArray(content)
                            ? content.map(text => <p key={text}>{text}</p>)
                            : content}
                    </div>
                    <div className={styles.btnGroup}>
                        <button
                            className={clsx(styles.button, styles.cancel)}
                            onClick={() => onClickButton(false)}
                        >
                            {cancelText}
                        </button>
                        <button
                            className={clsx(styles.button, styles.solid)}
                            onClick={() => onClickButton(true)}
                        >
                            {acceptText}
                        </button>
                    </div>
                </div>
            )}
        </>
    )
}

// export function useAsyncModal(asyncFunc) {
//     const [isPending, setIsPending] = useState(true)
//     async function callAsyncTask() {
//         // setIsPending(true)
//         try {
//             const data = await asyncFunc()
//             // setIsPending(false)
//             return data
//         } catch (error) {
//             // setIsPending(false)
//             return error
//         }
//     }
//     return [isPending, callAsyncTask]
// }

export default DynamicModal
