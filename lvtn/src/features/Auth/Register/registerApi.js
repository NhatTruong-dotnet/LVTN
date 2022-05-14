import axios from 'axios'
const baseApiURL = 'https://localhost:7298'

export default async function Register(formData) {
    try {
        const res = await axios.post(`${baseApiURL}/api/Auth/register`, {
            soDienThoai: formData.numberPhone,
            password: formData.password,
        })
        return { status: res.status }
    } catch ({ response, message }) {
        return {
            status: response.status,
            errorMessage: response.data || message,
        }
    }
}
