import axios from 'axios'

const baseApiURL = 'https://localhost:7298'

export const createNewPost = async ({ paramUrl, ...formData }, token) => {
    try {
        const res = await axios.post(
            `${baseApiURL}/api/baiDang/${paramUrl}/newPost`,
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
