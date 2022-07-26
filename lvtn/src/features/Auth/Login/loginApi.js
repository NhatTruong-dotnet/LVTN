import axios from 'axios'
const host = process.env.REACT_APP_HOST

export async function Login(formData) {
    try {
        const res = await axios.post(`${host}/api/Auth/login`, {
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
            `${host}/api/auth/changePassword`,
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

export const resetPassword = async numberPhone => {
    try {
        const res = await axios.post(
            `${host}/account/forgotPassword/${numberPhone}`
        )

        return {
            status: res.status,
        }
    } catch ({ response }) {
        return {
            status: response.status,
        }
    }
}
