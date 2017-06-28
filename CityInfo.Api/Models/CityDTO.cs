using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class CityDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest { get; set; }

        public ICollection<PointOfInterestsDto> PointsOfInterest { get; set; }
        = new List<PointOfInterestsDto>();




    }
}
