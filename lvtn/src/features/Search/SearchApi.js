import axios from 'axios'

const host = process.env.REACT_APP_HOST

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

export const getPostWithFilterParams = async queryString => {
    try {
        const res = await axios.get(`${host}/api/Filter/${queryString}`)
        return {
            status: res.status,
            listPost: res.data,
        }
    } catch ({ response }) {
        return { status: response.status, errorMessage: response.data }
    }
}
