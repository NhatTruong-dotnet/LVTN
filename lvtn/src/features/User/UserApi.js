import axios from 'axios'

const host = process.env.REACT_APP_HOST

export const getUserProfile = async sdt => {
    try {
        const res = await axios.get(`${host}/api/Auth/profile?sdt=${sdt}`)
        const { data, status } = res
        return { userProfile: data, status }
    } catch (error) {}
}

export const getUserPost = async sdt => {
    try {
        const res = await axios.get(
            `${host}/api/baiDang/mySold$soDienThoai=${sdt}`
        )
        const { data, status } = res
        return { userPost: data, status }
    } catch (error) {}
}
