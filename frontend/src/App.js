import React from 'react';
import Navbar from './components/Navbar';
import Home from './components/Home';
import Login from './components/Login';
import Register from './components/Register';
import {Routes, Route } from "react-router-dom"

function App() {
  return (
    <>
    <Navbar/>
    <Routes>
      <Route path="/home" element={<Home/>} />
      <Route path="/login" element={<Login />} />
      <Route path="register" element={<Register />} />  
    </Routes>
    </>
  );
}

export default App;
