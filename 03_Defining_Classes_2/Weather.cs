using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_2
{
    public enum WindDirection

    {

        North = 1, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest

    }

    public class Weather

    {

        public int WeatherID { get; set; }

        public DateTimeOffset WeatherDate { get; set; }

        public float Temperature { get; set; }

        public WindDirection WindDirection { get; set; }

        public int WindSpeed { get; set; }

        public bool IsPrecipitating { get; set; }

    }
}
