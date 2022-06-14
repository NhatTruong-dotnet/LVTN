import axios from 'axios'

const host = 'https://localhost:7298'

export const getAllNotify = async sdt => {
    try {
        const res = await axios.get(`${host}/api/BaiDang/notifications/${sdt}`)

        return { status: res.status, listNotify: res.data }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}
