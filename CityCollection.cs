using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Operation_Using_collections
{
    class CityCollection
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public double CityArea { get; set; }

        public double CityPopulation { get; set; }

        public bool isMetroCity { get; set; }

        public bool isAirportPresent { get; set; }

        public List<string> TouristPlaces { get; set; }


        public static List<CityCollection> GetCityCollections()
        {
            List<CityCollection> cityCollections = new List<CityCollection>();

            cityCollections.Add(new CityCollection
            {
                CityId = 201,
                CityName = "Pune",
                CityArea = 205.55,
                CityPopulation = 200,
                isAirportPresent = true,
                isMetroCity = true,
                TouristPlaces = new List<string> {"jaha","janachao","waha","ghumo" }
            });

            cityCollections.Add(new CityCollection
            {
                CityId = 202,
                CityName = "Varagaon",
                CityArea = 200.55,
                CityPopulation = 250,
                isAirportPresent = true,
                isMetroCity = true,
                TouristPlaces = new List<string> { "jaha", "janachao", "waha", "ghumo" }
            });

            cityCollections.Add(new CityCollection
            {
                CityId = 203,
                CityName = "Mumbai",
                CityArea = 105.55,
                CityPopulation = 2000,
                isAirportPresent = true,
                isMetroCity = true,
                TouristPlaces = new List<string> { "Juhu", "Chaupati", "waha", "ghumo" }
            });

            cityCollections.Add(new CityCollection
            {
                CityId = 204,
                CityName = "Hariyana",
                CityArea = 25.55,
                CityPopulation = 20,
                isAirportPresent = false,
                isMetroCity = true,
                TouristPlaces = new List<string> { "jaha", "janachao", "waha", "ghumo" }
            });

            cityCollections.Add(new CityCollection
            {
                CityId = 205,
                CityName = "Goa",
                CityArea = 110.55,
                CityPopulation = 600,
                isAirportPresent = false,
                isMetroCity = false,
                TouristPlaces = new List<string> { "jaha", "janachao", "waha", "ghumo" }
            });


            return cityCollections;
        }
    }
}
