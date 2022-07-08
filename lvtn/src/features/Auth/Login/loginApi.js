import axios from 'axios'
const baseApiURL = 'https://localhost:7298'

export async function Login(formData) {
    try {
        const res = await axios.post(`${baseApiURL}/api/Auth/login`, {
            soDienThoai: formData.numberPhone,
            password: formData.password,
        })
        const data = await res.data
        return { status: res.status, token: data }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}

export async function changePassword({ token, soDienThoai, password }) {
    try {
        const res = await axios.post(
            `${baseApiURL}/api/auth/changePassword`,
            { soDienThoai, password },
            {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            }
        )
        return { status: res.status }
    } catch (response) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}
