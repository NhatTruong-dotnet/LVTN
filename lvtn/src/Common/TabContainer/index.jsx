import styles from './tabcontainer.module.css'
import { useEffect, useRef } from 'react'

function TabContainer({ onClickOutside, children }) {
    const ref = useRef(null)

    useEffect(() => {
        const handleClickOutside = event => {
            console.log('click')
            if (ref.current && !ref.current.contains(event.target)) {
                onClickOutside && onClickOutside()
            }
        }
        document.addEventListener('click', handleClickOutside, true)
        return () => {
            document.removeEventListener('click', handleClickOutside, true)
        }
    }, [onClickOutside])

    // if (!props.show) return null

    return (
        <div className={styles.container} ref={ref}>
            {children}
        </div>
    )
}

export default TabContainer
