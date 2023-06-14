using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form3 : Form
    {
        List<Apartments> apartments = new List<Apartments>();
        public Form3()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
           
            string address = addressTextBox.Text;
            string category = categoryComboBox.SelectedItem.ToString();
            double area = Convert.ToDouble(areaTextBox.Text);
            int rooms = (int)roomsNumericUpDown.Value;
            double price = Convert.ToDouble(priceTextBox.Text);
            label4.Text = Base.addApartment(address, category, area, rooms, price);
            
               
            

        }

    }
}
