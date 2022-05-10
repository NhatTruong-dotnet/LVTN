import styles from './autocomplete.module.css'

function AutoComplete({ searchValue, items = [] }) {
    return (
        <div className={styles.autoComplete}>
            <div className={styles.searchValue}>
                Tìm kiếm từ khóa: "{searchValue}"
            </div>
            <div className={styles.item}>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Et,
                odit.
            </div>
            <div className={styles.item}>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Et,
                odit.
            </div>
            <div className={styles.item}>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Et,
                odit.
            </div>
            <div className={styles.item}>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Et,
                odit.
            </div>
            <div className={styles.item}>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Et,
                odit.
            </div>
        </div>
    )
}

export default AutoComplete
