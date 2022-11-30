import React from 'react';
import Navbar from './components/Navbar';
import Home from './components/Home';
import Login from './components/Login';
import Landing from './components/Landing';
import Addrestaurant from './components/Addrestaurant';
import Register from './components/Register';
import {Routes, Route } from "react-router-dom"

function App() {
  return (
    <>
    <Navbar/>
    <Routes>
      <Route path='/' element={<Landing/>}/>
      <Route path="/home" element={<Home/>} />
      <Route path="/addrestaurant" element={<Addrestaurant/>} />
      <Route path="/login" element={<Login />} />
      <Route path="/register" element={<Register />} />  
    </Routes>
    </>
  );
}

export default App;
