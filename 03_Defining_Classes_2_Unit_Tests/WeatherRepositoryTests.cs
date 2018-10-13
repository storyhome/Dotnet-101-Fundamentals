using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_2;

namespace _03_Defining_Classes_2_Unit_Tests
{
    [TestClass]
    public class WeatherRepositoryTests
    {
        // -- Field

        private Weather _weather;
        private WeatherRepository _weatherRepo; 

        // -- TestInit
        [TestInitialize]
        public void Arrange()
        {
            _weatherRepo = new WeatherRepository();
            _weather = new Weather
            {
                WeatherID = 1,
                IsPrecipitating = true,
                WindSpeed = 30,
                WindDirection = WindDirection.East,
                Temperature = 55,
                WeatherDate = DateTimeOffset.Now
            };

            _weatherRepo.AddWeatherItemToList(_weather);
        }
        [TestMethod]
        public void WeatherRepo_NumberofItemsInList_IsCorrectInt()
        {
            var expected = 1;
            var actual = _weatherRepo.GetWeatherList().Count;

            Assert.AreEqual(expected,actual);

        }
    }
}
