import React from 'react'
import {AiOutlineSearch} from 'react-icons/ai'

import photo from '../assets/table.svg'

const Home = () => {
  return (
    <div className='w-fulls h-screen bg-[#f3f3f3] flex flex-col min-h-screen justify-center items-center'>
            <img className='max-w-[300px] max-h-[500px] object-cover rounded-3xl relative drop-shadow-xl' src={photo} alt="" />
            <p className='text-3xl md:text-4xl sm:text-2xl font-sono drop-shadow-md'>Table Reservation</p>
            <div className='bg-gray-200 rounded-full flex items-center drop-shadow-lg px-2 w-[75%] sm:w-[400px] lg:w-[500px] mt-2'>
                <AiOutlineSearch size={20}/>
                <input type='text' placeholder='Search foods' className='bg-transparent p-2 focus:outline-none w-full'/>
            </div>
    </div>
  )
}

export default Home