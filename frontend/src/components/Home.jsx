import React from "react";
// import { AiOutlineSearch } from 'react-icons/ai';

const Home = () => {
    return (
        <div>
            <div>
                <input class="placeholder:italic placeholder:text-slate-400 block bg-white w-full border border-slate-300 rounded-md py-2 pl-9 pr-3 shadow-sm 
                focus:outline-none focus:border-sky-500 focus:ring-sky-500 focus:ring-1 sm:text-sm" placeholder="Search for anything..." type="text" name="search"/>
            </div>
            <div>
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
                <div class="relative">
                    <div class="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none">
                        <svg aria-hidden="true" class="w-5 h-5 text-gray-500 dark:text-gray-400" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" d="M6 2a1 1 0 00-1 1v1H4a2 2 0 00-2 2v10a2 2 0 002 2h12a2 2 0 002-2V6a2 2 0 00-2-2h-1V3a1 1 0 10-2 0v1H7V3a1 1 0 00-1-1zm0 5a1 1 0 000 2h8a1 1 0 100-2H6z" clip-rule="evenodd"></path>
                        </svg>
                    </div>
                        <input datepicker datepicker-autohide type="text" class="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Select date"></input>
                    </div>
            </div>
        </div>
    )
}

export default Home