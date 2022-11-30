import React from 'react';
import Navbar from './components/Navbar';
import Home from './components/Home';
import Login from './components/Login';
import Landing from './components/Landing';
import Addrestaurant from './components/Addrestaurant';
import Register from './components/Register';
import MakeReservation from './components/MakeReservation';
import {Routes, Route } from "react-router-dom"

function App() {
  return (
    <>
    <Navbar/>
    <Routes>
      <Route path='/landing' element={<Landing/>}/>
      <Route path="/" element={<Home/>} />
      <Route path="/addrestaurant" element={<Addrestaurant/>} />
      <Route path="/login" element={<Login />} />
      <Route path="/register" element={<Register />} />  
      <Route path='/makereservation' element={<MakeReservation/>}/>
    </Routes>
    </>
  );
}

export default App;
