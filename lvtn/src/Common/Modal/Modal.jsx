import { useEffect } from 'react'
import { useRef } from 'react'
import ReactDOM from 'react-dom'
import styles from './Modal.module.css'

const modalRoot = document.querySelector('#modal-root')

function Modal({ children }) {
    const modalRef = useRef()

    return ReactDOM.createPortal(
        <div className={styles.modal} ref={modalRef}>
            {children}
        </div>,
        modalRoot
    )
}

export default Modal
