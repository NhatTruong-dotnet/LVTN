import { configureStore } from '@reduxjs/toolkit'
import counterReducer from '../features/counter/counterSlice'
import createSagaMiddleware from 'redux-saga'

import RootSaga from './RootSaga'

const sagaMiddleware = createSagaMiddleware()

export const store = configureStore({
    reducer: {
        counter: counterReducer,
    },
    middleware: getDefaultMiddleware =>
        getDefaultMiddleware().concat(sagaMiddleware),
})

sagaMiddleware.run(RootSaga)
