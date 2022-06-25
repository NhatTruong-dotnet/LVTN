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
import Picker from './Components/Picker/Picker'
import { getFilterParams } from './data'
import SearchAddressPicker from './Components/SearchAddressPicker/SearchAddressPicker'

function Search(props) {
    const [showCategoryPicker, setShowCategoryPicker] = useState(false)
    const [searchCategory, setSearchCategory] = useState({
        id: 0,
        subCategoryId: -1,
        name: 'Tất cả danh mục',
    })
    const [address, setAddress] = useState({
        keySet: 'thanhPho',
        thanhPho: '',
        quanHuyen: '',
        phuongXa: '',
        displayText: 'Toàn quốc',
    })
    const [selectedParams, setSelectedParams] = useState({})

    const [filterParams, setFilterParams] = useState([])
    const { searchValue } = useParams()
    const searchPosts = useSelector(selectSearchListPost)
    const dispatch = useDispatch()
    const isLoading = useSelector(selectSearchPendingState)

    const handleSelectFilterItem = (key, value) => {
        setSelectedParams(prev => ({
            ...prev,
            [key]: value,
        }))
        dispatch({
            type: 'getPostWithFilterParams',
            searchCategory,
            address,
            params: { ...selectedParams, [key]: value },
        })
    }

    useEffect(() => {
        if (searchValue) {
            dispatch({ type: 'searchWithValue', searchValue })
        }
    }, [searchValue])

    useEffect(() => {
        setFilterParams(
            getFilterParams(searchCategory.id, searchCategory.subCategoryId)
        )
    }, [searchCategory.id, searchCategory.subCategoryId])
    console.log(selectedParams)
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
                    <SearchAddressPicker
                        setAddress={setAddress}
                        address={address}
                        searchCategory={searchCategory}
                        selectedParams={selectedParams}
                    />
                    {filterParams.map(item => (
                        <Picker
                            key={item.key}
                            filterItem={item}
                            handleClickItem={handleSelectFilterItem}
                            selectedValue={selectedParams[item.key]}
                        />
                    ))}
                </div>
                {showCategoryPicker && (
                    <SearchCategoryPicker
                        closeCategoryPicker={() => setShowCategoryPicker(false)}
                        setSearchCategory={setSearchCategory}
                    />
                )}
            </Frame>

            <Frame>
                {isLoading ? (
                    <Loading height={400} />
                ) : (
                    <ListPost listPost={searchPosts} />
                )}
            </Frame>
        </div>
    )
}
export default Search
