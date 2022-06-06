import { configureStore } from '@reduxjs/toolkit'
import counterReducer from '../features/counter/counterSlice'
import loginReducer from '../features/Auth/Login/loginSlice'
import registerReducer from '../features/Auth/Register/registerSlice'
import postReducer from '../features/Post/PostSlice'
import userReducer from '../features/User/UserSlice'
import signalRReducer from '../features/SignalR/SignalRSlice'

import createSagaMiddleware from 'redux-saga'

import RootSaga from './RootSaga'

const sagaMiddleware = createSagaMiddleware()

export const store = configureStore({
    reducer: {
        counter: counterReducer,
        login: loginReducer,
        register: registerReducer,
        post: postReducer,
        user: userReducer,
        signalR: signalRReducer,
    },
    middleware: getDefaultMiddleware =>
        getDefaultMiddleware().concat(sagaMiddleware),
})

sagaMiddleware.run(RootSaga)
