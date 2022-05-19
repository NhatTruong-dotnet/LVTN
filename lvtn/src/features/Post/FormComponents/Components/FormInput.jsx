import styles from '../RealEstate/index.module.css'
import AutoComplete from '../../../../Base/Header/Components/AutoComplete'
import clsx from 'clsx'
import { useEffect, useState } from 'react'

function FormInput({
    require,
    type = 'text',
    label,
    value,
    onChange,
    halfContainer,
    name,
    unit,
}) {
    const [message, setMessage] = useState('')

    const validateFormInput = () => {
        if (!value && require) {
            setMessage('Vui lòng điền vào trường này')
        }
    }

    const handleChangeFormInput = e => {
        if (message) {
            setMessage('')
        }
        onChange(e)
    }

    return (
        <>
            <div className={styles.inputGroup}>
                <input
                    type={type}
                    className={styles.input}
                    value={value}
                    onChange={handleChangeFormInput}
                    name={name}
                    onBlur={validateFormInput}
                />
                {/* {test && <AutoComplete />} */}
                <div className={styles.unit}>{unit}</div>

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
