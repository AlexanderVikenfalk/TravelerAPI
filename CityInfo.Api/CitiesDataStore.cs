using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDTO> Cities { get; set;}

        public CitiesDataStore()
        {

            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park.",
                PointsOfInterest = new List<PointOfInterestsDto>()
                {
                    new PointOfInterestsDto()
                    {
                        Id = 1,
                        Name = "Central Park",
                        Description = "Text",


                    },
                    new PointOfInterestsDto()
                    {
                        Id = 2,
                        Name = "Central Park",
                        Description = "Text",


                    }
                }
                },
                new CityDTO()
                {
                Id = 2,
                Name = "Antwerp",
                Description = "The one with that big Cathedral that was never finnished."
                },
                new CityDTO()
                {
                Id = 3,
                Name = "Paris",
                Description = "The one with that big tower."
                }
            };

        }
    }
}
