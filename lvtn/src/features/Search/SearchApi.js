import axios from 'axios'

const host = 'https://localhost:7298'

export const getPostWithCategoryId = async categoryId => {
    try {
        const res = await axios.get(
            `${host}/api/BaiDang/renderHomepage/${categoryId}`
        )
        return {
            status: res.status,
            listPost: res.data,
        }
    } catch ({ response }) {
        return { status: response.status, errorMessage: response.data }
    }
}

export const searchWithValue = async searchValue => {
    try {
        const res = await axios.get(`${host}/api/Search/${searchValue}`)
        return {
            status: res.status,
            listPost: res.data,
        }
    } catch ({ response }) {
        return { status: response.status, errorMessage: response.data }
    }
}
