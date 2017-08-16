using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }


            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Statue of Liberty",
                            Description = "It was built in 1886 and remains a famous world symbol of freedom and one of the greatest American icons."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "Along with the Statue of Liberty, The Empire State Building is New York's most famous landmark. "
                        }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Grand Place",
                            Description = "Antwerp's Grand Place (Grote Markt) with its town hall and numerous guild houses is the heart of the old town."
                        },
                        new PointOfInterest()
                        {
                            Name = "St. Paul's Church",
                            Description = "In the central city, the Veemarkt (the plaza that once functioned as a former cattle market) is home to the late Gothic St."
                        }
                    }
                },
                new City
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffel Tower",
                            Description = "Visiting the iconic symbol of Paris usually ranks as the number one thing to do for most tourists."
                        },
                        new PointOfInterest()
                        {
                            Name = "Louvre",
                            Description = "Topping the list of the world?s most visited museums, the Louvre Museum is located in the Louvre Palace with its signature glass pyramid marking its entrance."
                        }
                    }
                }



            };

            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}
