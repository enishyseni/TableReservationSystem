import React from "react";

const RestaurantPanel = () => {
    return (
        <div name="Candidates" className="flex flex-col pb-10 pr-1 pl-1">
            <div className="overflow-x-auto">
                <h2 className="text-4xl font-bold text-center py-2 pb-4">Waiting List</h2>
                <div className="flex justify-between py-3 pl-2">
                    <div className="relative max-w-xs"></div>
                </div>
                <div class="overflow-x-auto relative shadow-md sm:rounded-lg">
                    <table class="w-full text-sm text-left text-gray-500 dark:text-gray-400">
                        <thead class="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
                            <tr>
                                <th scope="col" class="py-3 px-6">
                                    Name
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Email
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Phone Number
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    No. of Persons
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Reservation Time
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Select table
                                </th>
                                <th scope="col" className="py-3 px-6"></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="bg-white border-b dark:bg-gray-800 dark:border-gray-700">
                                <th scope="row" class="py-4 px-6 font-medium text-gray-900 whitespace-nowrap dark:text-white">
                                    John Doe
                                </th>
                                <td class="py-4 px-6">
                                    johndoe@gmail.com
                                </td>
                                <td class="py-4 px-6">
                                    044111111
                                </td>
                                <td class="py-4 px-6">
                                    5
                                </td>
                                <td class="py-4 px-6">
                                    12:00
                                </td>
                                <td class="py-4 px-6">
                                <select className="font-poppins text-gray-700  bg-transparent w-full focus:outline-none ml-1 dark:text-gray-400">
                                    <option selected className="font-poppins text-slate-600 w-full">
                                    Table 1
                                    </option>
                                    <option className="font-poppins text-slate-600">Table 2</option>
                                    <option className="font-poppins text-slate-600">Table 3</option>
                                    <option className="font-poppins text-slate-600">Table 4</option>
                                    <option className="font-poppins text-slate-600">Table 5</option>
                                    <option className="font-poppins text-slate-600">Table 6</option>
                                </select>
                                </td>
                                <td class="flex items-center py-4 px-6 space-x-3">
                                    <button class="mr-2 font-medium text-blue-600 dark:text-blue-500">Approve</button>
                                    <button class="font-medium text-red-600 dark:text-red-500">Decline</button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>    
            </div>
            <div className="overflow-x-auto mt-10">
                <h2 className="text-4xl font-bold text-center py-2 pb-4">Approved List</h2>
                <div className="flex justify-between py-3 pl-2">
                    <div className="relative max-w-xs"></div>
                </div>
                <div class="overflow-x-auto relative shadow-md sm:rounded-lg">
                    <table class="w-full text-sm text-left text-gray-500 dark:text-gray-400">
                        <thead class="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
                            <tr>
                                <th scope="col" class="py-3 px-6">
                                    Name
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Email
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Phone Number
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    No. of Persons
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Reservation Time
                                </th>
                                <th scope="col" class="py-3 px-6">
                                    Selected Table
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="bg-white border-b dark:bg-gray-800 dark:border-gray-700">
                                <th scope="row" class="py-4 px-6 font-medium text-gray-900 whitespace-nowrap dark:text-white">
                                    John Doe
                                </th>
                                <td class="py-4 px-6">
                                    johndoe@gmail.com
                                </td>
                                <td class="py-4 px-6">
                                    044111111
                                </td>
                                <td class="py-4 px-6">
                                    5
                                </td>
                                <td class="py-4 px-6">
                                    12:00
                                </td>
                                <td class="py-4 px-6">
                                    Table 2
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    )
}

export default RestaurantPanel