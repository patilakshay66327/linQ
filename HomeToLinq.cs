using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Operation_Using_collections
{
    class HomeToLinq
    {
        public static void Main(string [] arg)
        {
            countryMethod();

            statemethod();

            citiesmethod();
        }

        public static void citiesmethod()
        {

            //***********************Operations on the State****************************

            var cityCollection = CityCollection.GetCityCollections();


            //query 1 -> Get First 2 cities where their area is greater that 110.55
            var sublist = cityCollection.Where(x => x.CityArea > 110.55).Take(2);

            foreach (var item in sublist)
            {
                Console.WriteLine($"First two cities having more population than 110.55 : {item.CityName}");
            }


            //query 2 ->Get All the cities which are the metrocities.
            var metroCityList = cityCollection.Where(x => x.isMetroCity == true);

            foreach (var item in metroCityList)
            {
                Console.WriteLine($"Cities which are metro cities : {item.CityName}");
            }

            //query 3 ->Get a city whose Id is 202
            var cityIdName = cityCollection.Where(x => x.CityId == 202);

            foreach (var item in cityIdName)
            {
                Console.WriteLine($"City name : {item.CityName} whose id is 202");
            }

            //query 4 -> Get a name of the city whose population is highest.
            var maxCityPopulation = cityCollection.Max(x => x.CityPopulation);
            var finalCityNameWithMaxPopulation = cityCollection.Where(y => y.CityPopulation == maxCityPopulation);

            foreach (var item in finalCityNameWithMaxPopulation)
            {
                Console.WriteLine($"City name : {item.CityName} whose population is {maxCityPopulation}");
            }


            //query 5 -> Get a city who do not have any airport.
            var noAirportQuery = cityCollection.Where(x => x.isAirportPresent == false);

            foreach (var item in noAirportQuery)
            {
                Console.WriteLine($" City Name which does not have any airport : {item.CityName}");
            }
            Console.ReadLine();

        }

        public static void countryMethod()
        {
            //***********************Operations on the Countries****************************

            var countryCollection = CountryCollection.GetCountryCollections();

            //query 1 -> country with currency rupee
            var countryWhitCurrencyRupee = countryCollection.Where(currency => currency.CountryCurrency.Equals("rupee"));

            foreach (var item in countryWhitCurrencyRupee)
            {
                Console.WriteLine($"Country With currency Rupees : {item.CountryName}");
            }

            //query 2 -> Capital of country with 100000000 and more population with developing status
            var countryCapitalQuery = countryCollection.Where(capitalcountrypopullation => capitalcountrypopullation.CountryPopulation > 1000000000); //&&
                                                                                                                                                      // capitalcountrypopullation.development.Equals("Developed"));

            foreach (var item1 in countryCapitalQuery)
            {
                Console.WriteLine($"Country Capital with population more than 10000000 and developing in development State is : {item1.CountryCapital}");
            }

            //query 3 -> list of the developed countries
            var developedCountryquery = countryCollection.Where(developmentOfCountry => developmentOfCountry.development.Equals("Developed"));

            foreach (var item in developedCountryquery)
            {
                Console.WriteLine($" Country which is developed already : {item.CountryName}");
            }

            //query 4 -> highest EquilityCapital
            var countryEquityCapital = countryCollection.Max(x => x.CountryEquityCapital);
            var finalcountryname = countryCollection.Where(y => y.CountryEquityCapital == countryEquityCapital);
            foreach (var item in finalcountryname)
            {
                Console.WriteLine($"Country with Heights Equity Capital : {item.CountryName} having {countryEquityCapital}");
            }

            //query 5 -> sorting the countries based on their population
            var sortedcountryquery = countryCollection.OrderByDescending(x => x.CountryPopulation);

            foreach (var item in sortedcountryquery)
            {
                Console.WriteLine($"Sorted List : {item.CountryName} having {item.CountryPopulation}");
            }
        }

        public static void statemethod()
        {
            //***********************Operations on the State****************************

            var stateCollection = StateCollection.GetStateCollections();

            //query 1 -> Get the name of a state where Id = 103
            var idWaliQuery = stateCollection.Where(x => x.stateId == 103);

            foreach (var item in idWaliQuery)
            {
                Console.WriteLine($" State Name {item.stateName} whos id is 103");
            }



            //query 2 -> Get first state where Population > 1300
            var subQuery = stateCollection.Where(x => x.statePopulation > 1300);

            var firstState = subQuery.First();

            Console.WriteLine($"First COuntry whos population is  mre than 1300 is : {firstState.stateName}");



            //query 3 -> Get name and id of the state which has Maximum genderEqualityRatio
            var maxValuegenderEuiti = stateCollection.Max(x => x.stateGenderEqualityRatio);
            var finalQuerylist = stateCollection.Where(y => y.stateGenderEqualityRatio == maxValuegenderEuiti);

            foreach (var item in finalQuerylist)
            {
                Console.WriteLine($"State Name : {item.stateName}  State Id :  {item.stateId}");
            }



            //query 4 -> Get the single state which has maximum population
            var maxPOpulation = stateCollection.Max(x => x.statePopulation);
            var population = stateCollection.Where(y => y.statePopulation == maxPOpulation);

            foreach (var item in population)
            {
                Console.WriteLine($" showing the maximum polpulated state is {item.stateName}");
            }



            //query 5 -> Get a state which does not have any river.

            //var noRiver = stateCollection.Where(x => x.stateRivers.Contains);




            //query 6 -> Select all the rivers from a state where name = "x"

            var listOfRivers = stateCollection.Where(x => x.stateName.Equals("Maharashtra")).SelectMany(x => x.stateRivers);

            foreach (var item in listOfRivers)
            {
                Console.WriteLine($"list of the rivers in Maharashtra : {item}");
            }
        }
    }
}
