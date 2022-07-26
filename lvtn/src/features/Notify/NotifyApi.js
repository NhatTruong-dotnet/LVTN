import axios from 'axios'

const host = process.env.REACT_APP_HOST

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
