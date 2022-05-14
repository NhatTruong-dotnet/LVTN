import styles from '../index.module.css'

function FormGroup({ title, children }) {
    return (
        <div className={styles.formGroup}>
            <div className={styles.title}>{title}</div>
            {children}
        </div>
    )
}

export default FormGroup
