import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import Navbar from './components/Navbar';
//import Home from './components/Home';
import Login from './components/Login';
import Register from './components/Register';
import {
  Route,
  Routes,
  BrowserRouter as Router,
} from "react-router-dom";

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <Router>
        <React.StrictMode>
            <Routes>
              <Route path="/register" element={<Register />} />  
            </Routes>
            <App />
        </React.StrictMode>
    </Router>
);

