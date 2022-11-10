import React from 'react';
import Navbar from './components/Navbar';
import Home from './components/Home';
import Login from './components/Login';
import Register from './components/Register';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom"

function App() {
  return (
    <Routes>
      <Route path="/" element={<Navbar />} />
      <Route path="/login" element={<Login />} />  
      <Route path="/register" element={<Register />} />  
    </Routes>
  );
}

export default App;
