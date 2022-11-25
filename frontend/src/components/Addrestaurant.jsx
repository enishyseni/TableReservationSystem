import React from "react";

function Addrestaurant () {
    return (
        <div className="">
            <div className="bg-white w-[100%] m-auto px-2 md:px-2 md-[60%] lg:w-[60%] ">
                <h1 className="text-3xl text-gray py-6 flex justify-center font-poppins">Register Restaurant</h1>
                <hr className="-mx-20" />

                <div className="py-8 w-[100%] items-center justify-center md:items-center md:justify-center">
                    <div className="flex mb-4 items-center">
                        <span className="flex justify-center border rounded-full w-6 h-6 mr-3 border-blue-500 text-blue-500">1</span>
                        <span className="font-bold text-lg text-gray-700 font-poppins">Restaurant inormation</span>
                    </div>
                    <div className="flex items-center justify-center mt-5 w-[100%] flex-col md:flex-row lg:flex-row">
                        <div className="w-[100%] px-1 md:w-[50%] lg:w-[50%]">
                            <label for="first_name" class="block mb-2 text-sm font-medium text-gray-900">Restaurant name</label>
                            <input type="text" id="first_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Name of restaurant" required></input>
                        </div>
                        <div className="w-[100%] px-1 md:w-[50%] lg:w-[50%]">
                            <label for="phone" class="block mb-2 text-sm font-medium text-gray-900">Phone number</label>
                            <input type="tel" id="phone" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="+383 4x xxx xxx" pattern="[0-9]{3}-[0-9]{2}-[0-9]{3}" required></input>
                        </div>
                    </div>
                    <div className="flex flex-col items-center justify-center mt-5 md:flex-row lg:flex-row">
                        <div className="w-[100%] px-1 md:w-[50%] lg:w-[50%]">
                            <label for="email" class="block mb-2 text-sm font-medium text-gray-900">Email address</label>
                            <input type="email" id="email" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="example@company.com" required></input>
                        </div> 
                        <div className="w-[100%] px-1 md:w-[50%] lg:w-[50%]">
                            <label for="first_name" class="block mb-2 text-sm font-medium text-gray-900">Address</label>
                            <input type="address" id="first_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="" required></input>
                        </div>
                    </div>
                    <div class="mb-5 mt-5">
                        <label class="mb-3 block text-base font-medium text-[#07074D]">
                        Type of business
                        </label>
                        <div class="flex flex-row space-x-4 lg:space-x-6">
                            <div class="flex items-center">
                                <input
                                type="radio"
                                name="radio1"
                                id="radioButton1"
                                class="h-5 w-5"
                                />
                                <label
                                for="radioButton1"
                                class="pl-3 text-base font-medium text-[#07074D]"
                                >
                                Restaurant
                                </label>
                            </div>
                            <div class="flex items-center">
                                <input
                                type="radio"
                                name="radio1"
                                id="radioButton2"
                                class="h-5 w-5"
                                />
                                <label
                                for="radioButton2"
                                class="pl-3 text-base font-medium text-[#07074D]"
                                >
                                Coffee Bar
                                </label>
                            </div>
                        </div>
                    </div>
                </div>

                <hr className="-mx-20" />

                <div className="py-8 w-[100%] items-center justify-center">
                    <div className="flex mb-4">
                        <span className="flex items-center justify-center border rounded-full w-6 h-6 mr-3 border-blue-500 text-blue-500">2</span>
                        <span className="font-bold text-lg text-gray-700">Drop Images</span>
                    </div>
                    <div className="flex w-[100%] items-center justify-center ">
                    <div className=" m-2 px-2 w-[100%] flex items-center justify-center md:w-[80%] lg:w-[80%]"> 
                        <div class="flex items-center justify-center w-full border border-gray-300 rounded-md">
                            <label for="dropzone-file" class="flex flex-col items-center justify-center w-[100%] h-64  border-gray-300  rounded-lg cursor-pointer bg-gray-50 dark:hover:bg-bray-800 dark:bg-gray-700 hover:bg-gray-100 dark:border-gray-600 dark:hover:border-gray-500 dark:hover:bg-gray-600">
                                <div class="flex flex-col items-center justify-center pt-5 pb-6">
                                    <svg aria-hidden="true" class="w-10 h-10 mb-3 text-gray-400" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7 16a4 4 0 01-.88-7.903A5 5 0 1115.9 6L16 6a5 5 0 011 9.9M15 13l-3-3m0 0l-3 3m3-3v12"></path></svg>
                                    <p class="mb-2 text-sm text-gray-500 dark:text-gray-400"><span class="font-semibold">Click to upload</span> or drag and drop</p>
                                    <p class="text-xs text-gray-500 dark:text-gray-400">SVG, PNG, JPG or GIF (MAX. 800x400px)</p>
                                </div>
                                <input id="dropzone-file" type="file" class="hidden" />
                            </label>
                        </div>                     
                    </div>
                </div>
                </div>
                <hr className="-mx-20" />

                <div className="py-8 w-[100%] items-center justify-center">
                    <div className="flex mb-4">
                        <span className="flex justify-center border rounded-full w-6 h-6 mr-3 border-blue-500 text-blue-500">3</span>
                        <span className="font-bold text-lg text-gray-700">Business Hours</span>
                    </div>
                    <div className="pt-2 w-full flex items-center justify-center md:flex-row md:w-[100%] lg:w-[100%]">
                        <table className="flex flex-col items-center justify-center w-[100%]">
                            <h1 className="text-center text-lg font-bold pb-4">Business Hours</h1>
                            <tbody>
                                <tr>
                                    <td className="font-bold ">Monday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Tuesday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Wednesday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Thursday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Friday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Saturday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                                <tr>
                                    <td className="font-bold ">Sunday: </td>
                                    <div date-rangepicker class="flex items-center mt-1">
                                        <div class="relative">
                                            <input name="start" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" p/>
                                        </div>
                                        <span class="mx-4 text-gray-500">to</span>
                                        <div class="relative">
                                            <input name="end" type="time" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"/>
                                        </div>
                                    </div>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <hr className="-mx-20" />
                    <div className="flex justify-center mt-5 mb-5">
                        <input type="submit" className="w-[30%] inline-block cursor-pointer px-6 py-2.5 font-medium leading-tight uppercase  shadow-md focus:outline-none bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white"/>
                    </div>
            </div>
        </div>
    )
}

export default Addrestaurant;