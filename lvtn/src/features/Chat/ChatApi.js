import axios from 'axios'

const host = 'https://localhost:7298'

export const getAllConversation = async (token, sdt) => {
    try {
        const res = await axios.get(`${host}/api/Chat/conversations/${sdt}`, {
            headers: {
                Authorization: `Bearer ${token}`,
            },
        })
        return {
            status: res.status,
            listConversation: res.data,
        }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}

export const getAllMessage = async conversationId => {
    try {
        const res = await axios.get(
            `${host}/api/Chat/conversation/details/${conversationId}`
        )
        return {
            status: res.status,
            listMessage: res.data,
        }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}

export const addNewMessage = async (
    token,
    sdt,
    currentChatUserSdt,
    messageText,
    imageId
) => {
    try {
        const res = await axios.post(
            `${host}/api/Chat/addMessage`,
            {
                messagesBy: sdt,
                messageTo: currentChatUserSdt,
                messageText,
                messageImageSource: imageId,
            },
            {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            }
        )

        return { status: res.status, id: res.data }
    } catch ({ response }) {
        return {
            status: response.status,
            errorMessage: response.data,
        }
    }
}
