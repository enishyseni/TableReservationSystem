import React from "react";
import { useState } from "react";
import {useNavigate} from "react-router-dom";
import {AiOutlineLogin, AiOutlineClose} from 'react-icons/ai';


function Navbar() {
    const history = useNavigate();
    const search = useNavigate();
   
    const [nav, setNav] = useState(false);
    return (
        <div className="max-w-[1640px] mx-auto flex justify-between items-center p-4">
            {/*Left side */}
            <div className="flex items-center">
                <button onClick={() => search("/home")} className="text-2xl sm:text-3xl lg:text-4xl px-2">
                    Book<span className="font-bold text-red-500">Table</span>
                </button>
            </div>
            
            {/* 
            <div className="bg-gray-200 rounded-full flex items-center px-2 w-[200px] sm:w-[400px] lg:w-[500px]">
                <AiOutlineSearch size={25}/>
                <input className="bg-transparent p-2 w-full focus:outline-none" type="text" placeholder="Search foods"/>
            </div>
            */}
            <div className="flex">
                {/* <button onClick={() => {history("register")}} className="font-poppins hidden lg:block mr-4 text-black flex  items-center py-2 rounded-full">
                    Not registered?
                </button> */}

                <button onClick={() => history("login")} className="font-poppins custom-button bg-black text-white flex text-sm items-center rounded-full">
                    <AiOutlineLogin size={20} className="mr-2"/>Login
                </button>
            </div>

            {/*Side drawer menu */}
            <div className= {nav ? 'fixed top-0 left-0 w-[300px] h-screen bg-white z-10 duration-300' : 'fixed top-0 left-[-100%] w-[300px] h-screen bg-white z-10 duration-300'}>
                <AiOutlineClose onClick={() => setNav()} size={30} className="absolute right-4 top-4 cursor-pointer"/>
                <h2 className="text-2xl p-4">
                    Book<span className="font-bold text-red-500">Table</span>
                </h2>
            </div>
        </div>
    )
}

export default Navbar