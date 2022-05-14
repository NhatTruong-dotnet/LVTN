import styles from '../index.module.css'
import clsx from 'clsx'

function FormInput({
    require,
    label,
    value,
    onChange,
    halfContainer,
    message,
    name,
}) {
    return (
        <>
            <div className={styles.inputGroup}>
                <input
                    type='text'
                    className={styles.input}
                    value={value}
                    onChange={onChange}
                    name={name}
                />

                <label
                    className={clsx(styles.label, {
                        [styles.hasValue]: Boolean(value),
                    })}
                >
                    {label}{' '}
                    {require && <span className={styles.required}>*</span>}
                </label>
                {message && (
                    <div
                        className={clsx(styles.formMessage, {
                            [styles.messageHalf]: halfContainer,
                        })}
                    >
                        {message}
                    </div>
                )}
            </div>
        </>
    )
}

export default FormInput
