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
    requireData = [],
    functionMapping,
    // formData,
}) {
    const [autoCompleteItems, setAutoCompleteItems] = useState(requireData)
    const [message, setMessage] = useState('')
    const [displayAutoComplete, setDisplayAutoComplete] = useState(false)

    const validateFormInput = () => {
        if (!value && require) {
            setMessage('Vui lòng điền vào trường này')
        } else {
            setMessage('')
        }
    }

    const filterListData = inputValue => {
        // if (typeof requireData === 'function') {
        //     const data = requireData()
        //     if (data) {
        //         const newAutoCompleteItems = data.filter(({ value }) =>
        //             value.includes(inputValue)
        //         )
        //         setAutoCompleteItems(newAutoCompleteItems)
        //     }
        // } else {
        //     const newAutoCompleteItems = requireData.filter(({ value }) =>
        //         value.includes(inputValue)
        //     )
        //     setAutoCompleteItems(newAutoCompleteItems)
        // }
        const newAutoCompleteItems = requireData.filter(({ value }) =>
            value.includes(inputValue)
        )
        setAutoCompleteItems(newAutoCompleteItems)
    }

    const handleChangeFormInput = e => {
        filterListData(e.target.value)

        if (message) {
            setMessage('')
        }
        onChange(e)
    }

    const handleSelectAutoCompleteItem = value => {
        console.log(value)
        setDisplayAutoComplete(false)
        setMessage('')

        // fake event instance =))
        onChange({ target: { value } })
    }

    const closeListDataWhenBlur = () => {
        setTimeout(() => {
            setDisplayAutoComplete(false)
        }, 100)
    }

    // useEffect(() => {
    //     if (typeof requireData === 'function') {
    //         const newData = requireData(formData)
    //         setAutoCompleteItems(newData)
    //     }
    // }, [formData?.phuKienLoaiPhuKien])

    // useEffect(() => {
    //     setAutoCompleteItems(requireData)
    // }, [requireData])

    return (
        <>
            <div className={styles.inputGroup}>
                <input
                    type={type}
                    className={styles.input}
                    value={value}
                    onChange={handleChangeFormInput}
                    name={name}
                    onBlur={() => {
                        validateFormInput()
                        closeListDataWhenBlur()
                    }}
                    onFocus={() => {
                        setDisplayAutoComplete(true)
                    }}
                />

                {/* {displayAutoComplete && autoCompleteItems.length > 0 && ( */}
                {displayAutoComplete && requireData.length > 0 && (
                    <AutoComplete
                        items={requireData}
                        onClickItem={handleSelectAutoCompleteItem}
                        functionMapping={functionMapping}
                    />
                )}

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
