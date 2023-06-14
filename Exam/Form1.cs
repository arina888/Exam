using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        List<Apartments> apartments = new List<Apartments>();
        public Form1()
        {
            InitializeComponent();

        }
        string address, category;
        double area, price;
        int rooms;
        private void findButton_Click(object sender, EventArgs e)
        {
            // �������� �������� ��������
            double minArea = Convert.ToDouble(minAreaTextBox.Text);
            double maxPrice = Convert.ToDouble(maxPriceTextBox.Text);
            int rooms = Convert.ToInt32(roomTextBox.Text);
            List<string> categories = new List<string>();
            foreach (object item in categoryCheckedListBox.CheckedItems)
            {
                categories.Add(item.ToString());
            }
            // ��������� �������� �� �������� ��������
            List<Apartments> filteredApartments = apartments.Where(ap =>
                ap.Area >= minArea && ap.Price <= maxPrice && ap.Rooms == rooms &&
                (categories.Count == 0 || categories.Contains(ap.Category))
            ).ToList();
            // ��������� �� ���� � ������� ����������
            filteredApartments = filteredApartments.OrderByDescending(ap => ap.Price).ToList();
            // ������� ��������� � �������
            apartmentsDataGridView.Rows.Clear();
            foreach (var apartment in filteredApartments)
            {
                apartmentsDataGridView.Rows.Add(
                    apartment.Address, apartment.Category,
                    apartment.Area, apartment.Rooms, apartment.Price
                );
            }
           
                Form1 form = new Form1();
                this.Hide();
                form.Owner = this;
                form.Show();
            

            //�������, ������� ����� ���������
           
        }
        public void insert_data(string[] str)
        {
           apartmentsDataGridView.Rows.Add(str[0], str[1], str[2], str[3], str[4]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}