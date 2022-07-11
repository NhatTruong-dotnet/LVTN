import axios from 'axios'

const host = 'https://localhost:7298'

export const createNewPost = async ({ paramUrl, ...formData }, token) => {
    try {
        const res = await axios.post(
            `${host}/api/baiDang/${paramUrl}/newPost`,
            formData,
            {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            }
        )

        return { status: res.status }
    } catch ({ response, message }) {
        console.log(response)
        return {
            status: response.status,
            errorMessage:
                response.data ||
                'Đã có lỗi xảy ra, vui lòng chờ trong giây lát và thử lại sau',
        }
    }
}

export const getPostWithSubCategoryId = async subCategoryId => {
    try {
        const res = await axios.get(
            `${host}/api/BaiDang/renderHomepage/${subCategoryId}`
        )
        const postData = res.data
        const status = res.status
        return { postData, status }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage:
                response.data ||
                'Đã có lỗi xảy ra, vui lòng chờ trong giây lát và tải lại trang',
        }
    }
}

export const getPostDetailWithId = async idPost => {
    try {
        const res = await axios.get(`${host}/api/baiDang/detail/${idPost}`)

        const { data, status } = res
        return { status, postDetail: data }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage:
                'Đã có lỗi xảy ra, vui lòng chờ trong giây lát và tải lại trang',
        }
    }
}

export const loadLocationData = async () => {
    try {
        const res = await axios.get('/LocationData/tree.json')
        return { locationData: res.data }
    } catch (error) {
        return {}
    }
}

export const editPost = async (
    { paramUrl, ...formData },
    token,
    preflightKey
) => {
    try {
        const res = await axios.put(
            `${host}/api/baiDang/${preflightKey}/updatePost`,
            formData,
            {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            }
        )

        return { status: res.status }
    } catch ({ response, message }) {
        console.log(response)
        return {
            status: response.status,
            errorMessage:
                response.data ||
                'Đã có lỗi xảy ra, vui lòng chờ trong giây lát và thử lại sau',
        }
    }
}

export const getEditPost = async (token, idPost, preflightKey) => {
    try {
        const res = await axios.get(
            `${host}/api/BaiDang/${preflightKey}/preflight?IdPost=${idPost}`,
            {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            }
        )

        console.log(res.data)
        return {
            status: res.status,
            updatePost: res.data,
        }
    } catch ({ response }) {
        return {
            status: response.status,
        }
    }
}
