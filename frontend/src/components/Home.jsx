import React from "react";
import { useState } from "react";
import { AiOutlineSearch } from 'react-icons/ai';
import { BiTime } from 'react-icons/bi'

function Home ()  {
    const [date, setDate] = useState();
    console.log("Date", date);
    return (
        <div className="">
            <div className="w-[100%] mx-auto flex-row p-4 bg-sky-50">
                <h1 className="font-sono text-center text-black text-3xl font-bold">Book Your Table</h1>
                <div className="flex flex-col lg:flex-row h-[150px] justify-center items-center w-[100%]">
                    <div className="w-[100%] bg-white rounded-xl flex items-center px-2 sm:w-[100%] md:w-[100%] lg:w-[65%] lg:mr-2 shadow-lg">
                            <AiOutlineSearch size={25}/>
                            <input className="bg-transparent p-2 w-full focus:outline-none" type="text" placeholder="Location, Restaurant or Cuisine"/>
                    </div>
                    <div className="w-[100%] lg:w-[40%] lg:space-x-6 flex space-x-1 items-center bg-white rounded-xl p-2 m-1 shadow-lg">
                        <div className="flex items-center">
                            <input className="flex items-center bg-transparent  w-full focus:outline-none font-poppins text-slate-500" type="date"  onChange={e=>setDate(e.target.value)}/>
                        </div>
                        <div className="flex justify-center items-center w-[35%] border-l-2 border-r-2 border-slate-300 ">
                            <BiTime size={25} className="ml-2"/>
                            {/* <input className="bg-transparent p-2 w-full border rounded-xl border-black focus:outline-none" type="time" placeholder="Time"/> */}
                            <select className="font-poppins text-slate-600 bg-transparent w-full focus:outline-none ml-1">
                                <option selected className="font-poppins text-slate-600 w-full">08:00</option>
                                <option className="font-poppins text-slate-600">08:15</option>
                                <option className="font-poppins text-slate-600">08:30</option>
                                <option className="font-poppins text-slate-600">08:45</option>
                                <option className="font-poppins text-slate-600">09:00</option>
                                <option className="font-poppins text-slate-600">09:15</option>
                                <option className="font-poppins text-slate-600">09:30</option>
                                <option className="font-poppins text-slate-600">09:45</option>
                                <option className="font-poppins text-slate-600">10:00</option>
                                <option className="font-poppins text-slate-600">10:15</option>
                                <option className="font-poppins text-slate-600">10:30</option>
                                <option className="font-poppins text-slate-600">10:45</option>
                                <option className="font-poppins text-slate-600">11:00</option>
                                <option className="font-poppins text-slate-600">11:15</option>      
                                <option className="font-poppins text-slate-600">11:30</option>      
                                <option className="font-poppins text-slate-600">11:45</option>
                                <option className="font-poppins text-slate-600">12:00</option>
                                <option className="font-poppins text-slate-600">12:15</option>      
                                <option className="font-poppins text-slate-600">12:30</option>      
                                <option className="font-poppins text-slate-600">12:45</option> 
                                <option className="font-poppins text-slate-600">13:00</option>
                                <option className="font-poppins text-slate-600">13:15</option>      
                                <option className="font-poppins text-slate-600">13:30</option>      
                                <option className="font-poppins text-slate-600">13:45</option> 
                                <option className="font-poppins text-slate-600">14:00</option>
                                <option className="font-poppins text-slate-600">14:15</option>      
                                <option className="font-poppins text-slate-600">14:30</option>      
                                <option className="font-poppins text-slate-600">14:45</option> 
                                <option className="font-poppins text-slate-600">15:00</option>
                                <option className="font-poppins text-slate-600">15:15</option>      
                                <option className="font-poppins text-slate-600">15:30</option>      
                                <option className="font-poppins text-slate-600">15:45</option>
                                <option className="font-poppins text-slate-600">16:00</option>
                                <option className="font-poppins text-slate-600">16:15</option>      
                                <option className="font-poppins text-slate-600">16:30</option>      
                                <option className="font-poppins text-slate-600">16:45</option>
                                <option className="font-poppins text-slate-600">17:00</option>
                                <option className="font-poppins text-slate-600">17:15</option>      
                                <option className="font-poppins text-slate-600">17:30</option>      
                                <option className="font-poppins text-slate-600">17:45</option>
                                <option className="font-poppins text-slate-600">18:00</option>
                                <option className="font-poppins text-slate-600">18:15</option>      
                                <option className="font-poppins text-slate-600">18:30</option>      
                                <option className="font-poppins text-slate-600">18:45</option>
                                <option className="font-poppins text-slate-600">19:00</option>
                                <option className="font-poppins text-slate-600">19:15</option>      
                                <option className="font-poppins text-slate-600">19:30</option>      
                                <option className="font-poppins text-slate-600">19:45</option>
                                <option className="font-poppins text-slate-600">20:00</option>
                                <option className="font-poppins text-slate-600">20:15</option>      
                                <option className="font-poppins text-slate-600">20:30</option>      
                                <option className="font-poppins text-slate-600">20:45</option>   
                                <option className="font-poppins text-slate-600">21:00</option>
                                <option className="font-poppins text-slate-600">21:15</option>      
                                <option className="font-poppins text-slate-600">21:30</option>      
                                <option className="font-poppins text-slate-600">21:45</option> 
                                <option className="font-poppins text-slate-600">22:00</option> 
                            </select>
                        </div>
                        <div className="flex items-center">
                            {/* <input className="bg-transparent p-2 w-full border rounded-xl border-black focus:outline-none" type="number" min="1" max="12" placeholder="Guests"/> */}
                            <select className="font-poppins text-slate-600 bg-transparent w-[100%] focus:outline-none">
                                {/* <option selected className="font-poppins text-slate-900 bg-transparent hidden">Nr.Guests</option> */}
                                <option selected className="font-poppins text-slate-700">1 person</option>
                                <option className="font-poppins text-slate-700">2 persons</option>
                                <option className="font-poppins text-slate-700">3 persons</option>
                                <option className="font-poppins text-slate-700">4 persons</option>
                                <option className="font-poppins text-slate-700">5 persons</option>
                                <option className="font-poppins text-slate-700">6 persons</option>
                                <option className="font-poppins text-slate-700">7 persons</option>
                                <option className="font-poppins text-slate-700">8 persons</option>
                                <option className="font-poppins text-slate-700">9 persons</option>
                                <option className="font-poppins text-slate-700">10 persons</option>
                                <option className="font-poppins text-slate-700">11 persons</option>
                                <option className="font-poppins text-slate-700">12 persons</option>
                                <option className="font-poppins text-slate-700">13 persons</option>
                                <option className="font-poppins text-slate-700">14 persons</option>      
                                <option className="font-poppins text-slate-700">15 persons</option>      
                            </select>
                        </div>
                    </div> 
                </div>
            </div>

            <div className='max-w-[1640px] mx-auto p-4 py-10 grid md:grid-cols-3 gap-6'>
            {/* Card */}
                <div className="rounded-xl relative">
                    <div className="font-sono absolute w-full h-full bg-black/60 rounded-3xl text-white shadow-lg shadow-gray-500">
                        <p className="text-bold text-3xl px-4 pt-6">Sonder</p>
                        <p className="px-4"><span className="font-bold">Address:</span> Ukë Bytyqi nr.19 10000 Pristina, Kosovo</p>
                        <button className='bg-transparent text-white border border-white rounded-xl p-1 absolute bottom-3 mx-4'>Make Reservation</button>
                    </div>
                    <img className='rounded-3xl max-h-[160px] md:max-h-[250px] w-full object-cover' src="https://images.pexels.com/photos/1267320/pexels-photo-1267320.jpeg?auto=compress&cs=tinysrgb&w=1600" alt="/" />
                </div>
                <div className="rounded-xl relative">
                    <div className="font-sono absolute w-full h-full bg-black/60 rounded-3xl text-white shadow-lg shadow-gray-500">
                        <p className="text-bold text-3xl px-4 pt-6">Gresa</p>
                        <p className="px-4"><span className="font-bold">Address:</span> 170 Fehmi Agani, Prishtina 10000</p>
                        <button className='bg-transparent text-white border border-white rounded-xl p-1 absolute bottom-3 mx-4'>Make Reservation</button>
                    </div>
                    <img className='rounded-3xl max-h-[160px] md:max-h-[220px] w-full object-cover' src="https://images.pexels.com/photos/299347/pexels-photo-299347.jpeg?auto=compress&cs=tinysrgb&w=1600" alt="/" />
                </div>
                <div className="rounded-xl relative">
                    <div className="font-sono absolute w-full h-full bg-black/60 rounded-3xl text-white shadow-lg shadow-gray-500">
                        <p className="text-bold text-3xl px-4 pt-6">French</p>
                        <p className="px-4"><span className="font-bold">Address:</span> Agim Ramadani a2 10000 Pristina, Kosovo</p>
                        <button className='bg-transparent text-white border border-white rounded-xl p-1 absolute bottom-3 mx-4'>Make Reservation</button>
                    </div>
                    <img className='rounded-3xl max-h-[160px] md:max-h-[250px] w-full object-cover' src="https://images.pexels.com/photos/1058277/pexels-photo-1058277.jpeg?auto=compress&cs=tinysrgb&w=1600" alt="/" />
                </div>
            </div>
        </div>
    )
}

export default Home