import styles from './autocomplete.module.css'

function AutoComplete({
    searchValue,
    items = [],
    onClickItem = () => {},
    forSearch,
    functionMapping,
    handleBackground,
}) {
    const mapFunction =
        typeof functionMapping === 'function'
            ? mapItem => functionMapping({ ...mapItem, handleBackground })
            : ({ value }) => (
                  <div
                      key={value}
                      className={styles.item}
                      onClick={() => {
                          onClickItem(value)
                          handleBackground()
                      }}
                  >
                      {value}
                  </div>
              )
    return (
        <div className={styles.autoComplete}>
            {forSearch && (
                <div className={styles.searchValue}>
                    Tìm kiếm từ khóa: "{searchValue}"
                </div>
            )}

            {items.map(mapFunction)}
        </div>
    )
}

export default AutoComplete
