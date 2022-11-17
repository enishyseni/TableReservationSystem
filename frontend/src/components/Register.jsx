import React from "react";
const register = () => {
    
    return (
        <div className="App bg-gray-50 h-screen w-screen relative overflow-hidden flex flex-col justify-center items-center">
       
     
     <div className='main flex flex-col flex-initial justify-evenly items-center'>
        
        <div className=" flex flex-col items-center container h-[444px] w-[444px] bg-gray-900 bg-opacity-10 rounded-2xl shadow-5xl relative z-2 border border-opacity-30 border-r-0 border-b-0 backdrop-filter backdrop-blur-sm">
        <div className="font-poppins h-35 w-64 text-white bg-black text-2xl tracking-wider py-2 px-5 rounded-full -mt-3"><span className='px-12'>Register</span></div>
          <form className="h-full w-5/6 flex flex-col justify-evenly items-stretch">
            <div className="name-surname flex justify-between ">
                <input type="text" placeholder="Name" className="w-1/2 font-poppins text-slate-900 bg-transparent focus:outline-none border mr-2 border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
                <span className=""></span>
                <input type="text" placeholder="Surname" className="w-1/2 font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
            </div>
            <select className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider">
                <option selected className="font-poppins text-slate-900 bg-transparent">Select city</option>
                <option className="font-poppins text-slate-900">Prishtina</option>
                <option className="font-poppins text-slate-900">Ferizaj</option>
                <option className="font-poppins text-slate-900">Gjilan</option>
                <option className="font-poppins text-slate-900">Prizren</option>
                <option className="font-poppins text-slate-900">Peja</option>
                <option className="font-poppins text-slate-900">Gjakova</option>
                <option className="font-poppins text-slate-900">Mitrovica</option>    
            </select>
            <input type="text" placeholder="Email or phone number" className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
            <input type="password" placeholder= "Password" className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
            <input type="password" placeholder= "Confirm password" className="font-poppins text-slate-900 bg-transparent focus:outline-none border border-r-0 border-t-0 border-l-0 border-black tracking-wider"/>
            <button  className='font-poppins text-white bg-black cursor-pointer text-xl rounded-full px-5 py-1 bg-opacity-60 hover:bg-black hover:bg-opacity-80 tracking-wider'>Confirm</button>
          </form>
        </div>
    </div>    
    </div>
    )
};

export default register;