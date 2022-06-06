import React, { Suspense } from 'react'
import { createRoot } from 'react-dom/client'
import { Provider } from 'react-redux'
import { store } from './app/store'
import App from './App'
import reportWebVitals from './reportWebVitals'
import GlobalStyle from './Common/GlobalStyle/GlobalStyle'
import { BrowserRouter } from 'react-router-dom'
import './index.css'
import Loader from './Common/loader/Loader'

const container = document.getElementById('root')
const root = createRoot(container)

root.render(
    <React.StrictMode>
        <Suspense fallback={<Loader />}>
            <BrowserRouter>
                <Provider store={store}>
                    <GlobalStyle>
                        <App />
                    </GlobalStyle>
                </Provider>
            </BrowserRouter>
        </Suspense>
    </React.StrictMode>
)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals()
