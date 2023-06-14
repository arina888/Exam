using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Base
    { 
        private static List<Apartments> apartments = new List<Apartments>();
        internal static   Apartments apartment
        {
            get => default;
            set
            {
            }
        }

      


        public static void showApartments(DataGridView apartmentsDataGridView, int index)
        {
           
            foreach (Apartments apartment in apartments)
            {
                apartmentsDataGridView.Rows.Add();
                apartmentsDataGridView.Rows[index].Cells[0].Value = apartment.Address;
                apartmentsDataGridView.Rows[index].Cells[1].Value = apartment.Category;
                apartmentsDataGridView.Rows[index].Cells[2].Value = apartment.Area;
                apartmentsDataGridView.Rows[index].Cells[3].Value = apartment.Rooms;
                apartmentsDataGridView.Rows[index].Cells[4].Value = apartment.Price;
                index++;
            }
               
        }
        public static string addApartment(string address, string category, double area, int rooms, double price)
        {
            foreach (Apartments ap in apartments)
            {
                Apartments apartment = new Apartments(address, category, area, rooms, price);
                apartment.Address = address;
                apartment.Category = category;
                apartment.Area = area;
                apartment.Rooms = rooms;
                apartment.Price = price;
                apartments.Add(apartment);
                return "Квартира зарегистрирована";
            }

                
            
           
        }

    }
}
