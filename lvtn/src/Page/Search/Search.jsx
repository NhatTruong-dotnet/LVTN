import React from 'react'
import { useState } from 'react'
import Frame from '../../Common/Frame/Frame'
import SearchCategoryPicker from './Components/SearchCategoryPicker/SearchCategoryPicker'
import styles from './search.module.css'
import ListPost from '../../Common/ListPost/ListPost'
import { useDispatch, useSelector } from 'react-redux'
import {
    selectSearchListPost,
    selectSearchPendingState,
} from '../../features/Search/SearchSlice'
import { useParams } from 'react-router-dom'
import { useEffect } from 'react'
import Loading from '../../Common/Loading/Loading'

function Search(props) {
    const [showCategoryPicker, setShowCategoryPicker] = useState(false)
    const [searchCategory, setSearchCategory] = useState({
        id: 0,
        name: 'Tất cả danh mục',
    })
    const { searchValue } = useParams()
    const searchPosts = useSelector(selectSearchListPost)
    const dispatch = useDispatch()
    const isLoading = useSelector(selectSearchPendingState)

    useEffect(() => {
        if (searchValue) {
            dispatch({ type: 'searchWithValue', searchValue })
        }
    }, [searchValue])

    return (
        <div className='grid wide'>
            <Frame>
                <div className={styles.filterContainer}>
                    <div className={styles.filterItem}>
                        <span
                            className={styles.filterValue}
                            onClick={() => setShowCategoryPicker(true)}
                        >
                            {searchCategory.name}
                            <span className={styles.filterIcon}></span>
                        </span>
                    </div>
                </div>
                {showCategoryPicker && (
                    <SearchCategoryPicker
                        closeCategoryPicker={() => setShowCategoryPicker(false)}
                        setSearchCategory={setSearchCategory}
                    />
                )}
            </Frame>

            <Frame>
                {isLoading ? <Loading /> : <ListPost listPost={searchPosts} />}
            </Frame>
        </div>
    )
}
export default Search
