using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType 
        {Male=0, Female=1, Unkonwn}



        static void Main(string[] args)
        {
           

            // -- Declaration
            int myAge;

            // -- Initialization
            myAge = 42;


            // -- Integers
            // -- Other Types
            int i = 100;
            byte by = 255;
            short sh = 32767;
            int IToo = 200;
            float PI = 3.14159265314590000f;
            Console.WriteLine(PI);
            double d = 780.01;
            decimal p = 7.8m;
            int? noValue = null;
            long youtubeMinutesWatched = 923232334434;
            Console.WriteLine(youtubeMinutesWatched);


            // -- Booleans

            bool isEarly = true;

            //== Boolean Logic/Conditionals

            if (isEarly)
            {
                Console.WriteLine("Need more coffee.");
                Console.WriteLine("Yes indeed");
            }


            // -- Declare Enum
            GenderType myGender = GenderType.Male;
            var jenna = GenderType.Female;
            var myBirthYear = "1976";

            switch (myGender)
            {
                case GenderType.Male:
                    Console.WriteLine("Welcome Sir");
                    break;

                case GenderType.Female:
                    Console.WriteLine("Welcome Mam!");
                    break;

                case GenderType.Unkonwn:
                    Console.WriteLine("Howdy!");
                    break;
                   
            }
        }
    }
}
