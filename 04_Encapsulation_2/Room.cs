using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    public class Room
    {
        private const double MAX_LENGTH = 30d;
        private const double MIN_LENGTH = 6d;
        private const double MAX_HEIGHT = 6d;


        private double _length;

        public double Length
        {
            get => _length;

            set
            {
                if (value < MIN_LENGTH || value > MAX_LENGTH)
                    throw new Exception("Invalid Lenght");
                else

                    _length = value;
            }
        }

        


        private double _width;

        public double Width
        {
            get => _width;
            set
            {
                if (value < MIN_LENGTH || value > MAX_LENGTH)
                throw new Exception("Invalid Width");
                else
               
                _width = value;
            }
        }

        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                if (value > MAX_HEIGHT )
                    throw new Exception("Invalid Height");
                else
                _height = value;
            }
        }


        //public decimal Height { get; set; }
        public decimal Area { get; set; }

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

        }

        //TODO: Finish Module

        //public  GetAreaSpace()
        //{
        //    if (length < MIN_LENGTH & width < MIN_LENGTH || length > MAX_LENGTH & width > MAX_LENGTH)
        //        return 0;
        //    else
        //    {
        //        Room _room = new Room();

        //        _room.Length;


        //    }



        



        }


       

  }



   