import styles from './autocomplete.module.css'

function AutoComplete({
    searchValue,
    items = [],
    onClickItem = () => {},
    forSearch,
}) {
    return (
        <div className={styles.autoComplete}>
            {forSearch && (
                <div className={styles.searchValue}>
                    Tìm kiếm từ khóa: "{searchValue}"
                </div>
            )}

            {items.map(({ value }) => (
                <div
                    key={value}
                    className={styles.item}
                    onClick={() => {
                        onClickItem(value)
                    }}
                >
                    {value}
                </div>
            ))}
        </div>
    )
}

export default AutoComplete
