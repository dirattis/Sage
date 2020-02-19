import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux'
import 'normalize.css';
import './styles/reset-local.css';
import './styles/global.css';
import './styles/index.css';
import App from './main/App';
import configureStore from './main/store'

const store = configureStore();

ReactDOM.render(
    <Provider store={store}>
        <App />
    </Provider>
, document.getElementById('root'));
