using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Operation_Using_collections
{
    class StateCollection
    {
        public int stateId { get; set; }

        public string stateName { get; set; }

        public double stateArea { get; set; }

        public long statePopulation { get; set; }

        public double stateGenderEqualityRatio { get; set; }

        public List<string> stateCities { get; set; }

        public List<string> stateRivers { get; set; }


        public static List<StateCollection> GetStateCollections()
        {
            List<StateCollection> stateCollections = new List<StateCollection>();

            stateCollections.Add(new StateCollection
            {
                stateId = 101,
                stateName ="Maharashtra",
                statePopulation = 1500,
                stateArea = 150.2,
                stateCities = new List<string> {"nasik","pune","mumbai"},
                stateGenderEqualityRatio = 0.7,
                stateRivers = new List<string> {"Godawari","Tapi","Wasundhara"}
            });

            stateCollections.Add(new StateCollection
            {
                stateId = 102,
                stateName = "Panjab",
                statePopulation = 1520,
                stateArea = 50.2,
                stateCities = new List<string> { "gurgaon", "hariyana", "cahna" },
                stateGenderEqualityRatio = 0.2,
                stateRivers = new List<string> { "ganga", "trupti", "delta" }
            });

            stateCollections.Add(new StateCollection
            {
                stateId = 103,
                stateName = "Asam",
                statePopulation = 150,
                stateArea = 60.285,
                stateCities = new List<string> { "nasik", "pune", "mumbai" },
                stateGenderEqualityRatio = 0.3,
            });

            stateCollections.Add(new StateCollection
            {
                stateId = 104,
                stateName = "Gujrat",
                statePopulation = 1000,
                stateArea = 120.2,
                stateCities = new List<string> { "hara", "bhara", "kabab" },
                stateGenderEqualityRatio = 0.3,
                stateRivers = new List<string> { "jasusi", "nadi", "pani" }
            });

            stateCollections.Add(new StateCollection
            {
                stateId = 105,
                stateName = "kerala",
                statePopulation = 1300,
                stateArea = 30.22,
                stateCities = new List<string> { "natu", "chaitri", "rajarampur" },
                stateGenderEqualityRatio = 1.7,
                stateRivers = new List<string> { "nillu", "kantham", "wishwashwari" }
            });

            return stateCollections;
        }

    }

}
