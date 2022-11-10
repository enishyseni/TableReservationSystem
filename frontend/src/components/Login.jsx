import React from "react";
import {useNavigate} from "react-router-dom";

function Login() {
  const link = useNavigate ();
  link('/Register')
    return (
        <div className="App bg-gray-50 h-screen w-screen relative overflow-hidden flex flex-col justify-center items-center">
        <div className="  h-40-r w-40-r bg-gradient-to-r from-green-400 to-blue-500 rounded-full absolute left-2/3 -top-56 animate-pulse"></div>
        <div className="h-35-r w-35-r bg-gradient-to-r from-red-400 via-pink-500 to-purple-500 rounded-full absolute top-96 -left-20 animate-pulse"></div>
     
     <div className='main flex flex-col justify-evenly items-center'>
        
        <div className=" flex flex-col items-center container h-96 w-96 bg-gray-900 bg-opacity-10 rounded-2xl shadow-5xl relative z-2 border border-opacity-30 border-r-0 border-b-0 backdrop-filter backdrop-blur-sm">
        <div className="font-poppins h-35 w-60 text-white bg-black text-2xl tracking-wider py-2 px-5 rounded-full -mt-3"><span className='px-12'>Welcome</span></div>
          <form className="h-full flex flex-col justify-evenly items-center">
            
              <input type="text" placeholder="Email or phone number" className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
              <input type="password" placeholder= "Password" className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
              <button className="font-poppins text-slate-500 text-white text-xs tracking-wider hover:text-gray-900" > Forgot your password? </button>
              <button onClick={() => { link("/Register")}} className="font-poppins text-slate-500 text-white text-xs tracking-wider hover:text-gray-900 -mt-6" >Do not have an account? Register now </button>
            <input type="Submit" className='font-poppins text-white bg-black cursor-pointer text-xl rounded-full px-5 py-1 bg-black bg-opacity-60 hover:bg-black hover:bg-opacity-80 tracking-wider'/>
          </form>
        </div>
    </div>    
    </div>
    )
};

export default Login;
