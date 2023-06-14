using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Apartments
    {
        public string Address { get; set; }
        public string Category { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public int Rooms { get; set; }


        public Apartments(string address, string category, double area, int rooms,double price)
        {
            this.Address = address;
            this.Category = category;
            this.Area = area;
            this.Rooms = rooms;
            this.Price = price;
        }

    }
}
