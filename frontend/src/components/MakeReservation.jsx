import React from "react";
import { useState, useEffect, useRef } from "react";
import { AiOutlineVerticalRight, AiOutlineVerticalLeft } from "react-icons/ai";

import { FaFacebook } from "react-icons/fa";
import { AiFillInstagram } from "react-icons/ai";
import { RiSnapchatLine } from "react-icons/ri";

const featuredProducts = [
  "/img/photo.jpeg",
  "/img/photo1.jpeg",
  "/img/photo2.webp",
];

let count = 0;
const Reservation = () => {
  const [currentIndex, setCurrentIndex] = useState(0);

  const slideRef = useRef();

  const removeAnimation = () => {
    slideRef.current.classList.remove("fade-anim");
  };

  useEffect(() => {
    slideRef.current.addEventListener("animationend", removeAnimation);
  }, []);

  // const startSlider = () => {
  //   setInterval(() => {
  //     handleOnNextClick();
  //   }, 3000);
  // };

  const handleOnNextClick = () => {
    count = (count + 1) % featuredProducts.length;
    setCurrentIndex(count);
    slideRef.current.classList.add("fade-anim");
  };
  const handleOnPrevClick = () => {
    const productsLength = featuredProducts.length;
    count = (currentIndex + productsLength - 1) % productsLength;
    setCurrentIndex(count);
    slideRef.current.classList.add("fade-anim");
  };

  return (
    <div className="w-full h-screen p-1 flex">
      <div className="grid grid-cols-1 xl:grid-cols-4 lg:grid-cols-2 m-auto h-[550px] shadow-xl shadow-gray-300 rounded-2xl">
        <div ref={slideRef} className="w-full h-[550px] relative">
          <img
            src={featuredProducts[currentIndex]}
            className="w-full h-full object-cover drop-shadow-2xl md:rounded-l-2xl"
            alt=""
          />
          <div className="absolute w-full top-1/2 transform -translate-y-1/2 px-3 flex justify-between items-center">
            <button
              onClick={handleOnPrevClick}
              className="bg-black text-white p-1 rounded-full bg-opacity-50 cursor-pointer hover:bg-opacity-80 transition"
            >
              <AiOutlineVerticalRight size={30} />
            </button>
            <button
              onClick={handleOnPrevClick}
              className="bg-black text-white p-1 rounded-full bg-opacity-50 cursor-pointer hover:bg-opacity-80 transition"
            >
              <AiOutlineVerticalLeft size={30} />
            </button>
          </div>
        </div>
        <div className="p-4 flex flex-col justify-around items-center">
          <div className="relative">
            <h1 className="md:text-4xl text-3xl font-bold font-sono mb-2 mt-2 md:-mt-2">
              Sonder
            </h1>
            <h2 className="text-lg md:text-xl">Reservation for</h2>
          </div>
          <div className="w-full grid grid-cols-1 gap-2 rounded-xl relative p-4 drop-shadow-md shadow-black">
            <select
              name="Number of persons"
              id="#"
              className="outline-none hover:border-b-4 duration-100 cursor-pointer ease-in-out border-black/10 p-2 rounded-lg"
            >
              <option className="font-poppins text-slate-700">1 person</option>
              <option className="font-poppins text-slate-700">2 persons</option>
              <option className="font-poppins text-slate-700">3 persons</option>
              <option className="font-poppins text-slate-700">4 persons</option>
              <option className="font-poppins text-slate-700">5 persons</option>
              <option className="font-poppins text-slate-700">6 persons</option>
            </select>
            <input
              type="date"
              name="#"
              id="#"
              className="outline-none hover:border-b-4 duration-100 ease-in-out cursor-pointer border-black/10 p-2 rounded-lg"
            />
            <input
              type="time"
              name="#"
              id="#"
              className="outline-none hover:border-b-4 duration-100 ease-in-out cursor-pointer border-black/10 p-2 rounded-lg"
            />
          </div>
          <button
            type="submit"
            className="bg-[#065f46] hover:bg-[#064e3b] shadow-md shadow-[#047857] border-none duration-150 ease-in-out text-white rounded-full relative w-[50%] p-2 cursor-pointer text-sm"
          >
            Make Reservation
          </button>
        </div>
        <div className="grid w-full justify-around items-center md:shadow-gray-300">
          <h1 className="text-center  text-xl p-2 md:text-3xl font-sono">
            Working Hours
          </h1>
          <table className="table-auto text-slate-500 pl-3">
            <tbody className="md:text-lg font-sono ">
              <tr className="">
                <td>Monday</td>
                <td>07:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td>Tuesday</td>
                <td>07:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td>Wednesday</td>
                <td>07:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td>Thursday</td>
                <td>07:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td>Friday</td>
                <td>07:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td className="">Saturday</td>
                <td>08:00 Am - 22:30 PM</td>
              </tr>
              <tr>
                <td>Sunday</td>
                <td>09:00 Am - 05:00 PM</td>
              </tr>
            </tbody>
          </table>
          <div className="flex m-auto mt-2 cursor-pointer">
            <FaFacebook size={23} className="mr-1" />
            <AiFillInstagram size={25} className="mr-1" />
            <RiSnapchatLine size={25} className="mr-1" />
          </div>
        </div>
        <div className="w-full">
          <iframe
            className="w-full md:rounded-r-2xl h-full"
            id="gmap_canvas"
            src="https://maps.google.com/maps?q=Uk%C3%AB%20Bytyqi%20nr.19,%20Pristina,%20Kosovo&t=&z=15&ie=UTF8&iwloc=&output=embed"
            frameBorder="0"
            scrolling="no"
            marginHeight="0"
            marginWidth="0"
          ></iframe>
          {/* Address */}
        </div>
      </div>
    </div>
  );
};

export default Reservation;
