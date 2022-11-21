using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Persistence;
using Domain.Entities;


namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)

        {
            if (context.Reservations.Any())
                return;

            var reservations = new List<Reservation>
            {
                new Reservation{

                    Name ="Sami",
                    PhoneNumber = 044444333,
                    Email = "SamiQorri@gmail.com",
                    StartDateTime=  DateTime.Now.AddMonths(-2),
                    NumberOfPersons = 4,
                    Description ="dsaesasd",



                },
                new Reservation{

                    Name ="Artin",
                    PhoneNumber = 044444333,
                    Email = "ArtinRexhepi@gmail.com",
                    StartDateTime=  DateTime.Now.AddMonths(-2),
                    NumberOfPersons = 4,
                    Description ="dsaesasd",



                }


            };

            await context.Reservations.AddRangeAsync(reservations);
            //await context.SaveChangesAsync();



        }

    }
}