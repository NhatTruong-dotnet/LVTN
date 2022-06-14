import Frame from '../../Common/Frame/Frame'
import styles from './category.module.css'
import categories from '../CreatePost/categoryData'
import { useParams } from 'react-router-dom'
import { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { selectListPost } from '../../features/Post/PostSlice'
import ListPost from '../../Common/ListPost/ListPost'
import clsx from 'clsx'

function Category(props) {
    const { categoryId } = useParams()
    const [selectedSubCategoryId, setSelectedSubcategoryId] = useState()
    const [subCategoryItems, setSubCategoryItems] = useState(() =>
        getSubCategory(categoryId)
    )
    const dispatch = useDispatch()
    const listPost = useSelector(selectListPost)

    function getSubCategory(categoryId) {
        const selectedCategory = categories.find(
            category => category.id === +categoryId
        )

        return selectedCategory.subCategory
    }

    function handleSelectSubCategory(subCategoryId) {
        localStorage.setItem('lastSubCategories', subCategoryId)
        setSelectedSubcategoryId(subCategoryId)
    }

    function getCategoryName(categoryId) {
        const selectedCategory = categories.find(
            category => category.id === +categoryId
        )
        return selectedCategory.name
    }

    useEffect(() => {
        if (categoryId) {
            const newSubcategories = getSubCategory(categoryId)
            setSubCategoryItems(newSubcategories)
        }
    }, [categoryId])

    useEffect(() => {
        if (selectedSubCategoryId) {
            dispatch({
                type: 'getPost',
                lastSubCategories: selectedSubCategoryId,
            })
        }
    }, [selectedSubCategoryId])

    return (
        <div className='grid wide'>
            <Frame title={`Khám phá danh mục ${getCategoryName(categoryId)}`}>
                <div className='row'>
                    {subCategoryItems.map(({ id, name }) => (
                        <div className='col l-3' key={id}>
                            <div
                                className={clsx(styles.subCateItem, {
                                    [styles.selected]:
                                        id === +selectedSubCategoryId,
                                })}
                                onClick={() => handleSelectSubCategory(id)}
                            >
                                {name}
                            </div>
                        </div>
                    ))}
                </div>
            </Frame>
            <Frame title={'Bài đăng'}>
                <ListPost listPost={listPost} />
            </Frame>
        </div>
    )
}

export default Category
