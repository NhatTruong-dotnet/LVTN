import { createSlice } from '@reduxjs/toolkit'
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr'

const initialState = {
    connection: null,
}

const signalRSlice = createSlice({
    name: 'signalR',
    initialState,
    reducers: {
        connectSignalRServer: (state, action) => {
            if (!action.payload.url) return

            const connection = new HubConnectionBuilder()
                .withUrl(action.payload.url)
                .configureLogging(LogLevel.Information)
                .build()

            state.connection = connection
        },
    },
})

const { reducer, actions } = signalRSlice

export const { connectSignalRServer } = actions

export const selectConnection = state => state.signalR.connection

export default reducer
