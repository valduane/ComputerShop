using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {

        public int vacuumCount = 0;
        public int phonesCount = 0;
        public int headphonesCount = 0;
        private int[] amount = new int[3];

        Product vacuum = new Product();
        Product phone = new Product();
        Product headphone = new Product();

        SaveAndLoadFile file = new SaveAndLoadFile();

        string dirOfAmount = @"C:\Users\valduane\Desktop\amountOfProduct.txt";
        public Form1()
        {
            InitializeComponent();
            initProduccts();
        }

        void initProduccts()
        {
            vacuum.ID = 1;
            vacuum.name = "Пылесос STARWIND SCH1010";
            vacuum.price = 1999;
            vacuum.amount = vacuumCount;

            phone.ID = 2;
            phone.name = "Смартфон Huawei P40 128 ГБ серебристый";
            phone.price = 40000;
            phone.amount = phonesCount;

            headphone.ID = 3;
            headphone.name = "Наушники беспроводные TCL ELIT400BT";
            headphone.price = 5500;
            headphone.amount = headphonesCount;

            readFromFile();
        }

        public Product GetVacuumObj()
        {
            return vacuum;
        }
        public Product GetPhoneObj()
        {
            return phone;
        }
        public Product GetHeadphoneObj()
        {
            return headphone;
        }
        public int GetVacuumPrice()
        {
            return vacuum.price;
        }
        public int GetPhonePrice()
        {
            return phone.price;
        }
        public int GetHeadphonePrice()
        {
            return headphone.price;
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WarehouseEmployee_Click(object sender, EventArgs e)
        {
            WarehouseEmployee f = new WarehouseEmployee();
            openNewForm(f);
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            Cashier f = new Cashier();
            openNewForm(f);
        }

        private void User_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            openNewForm(f);
        }

        private void Leadership_Click(object sender, EventArgs e)
        {
            
        }

        private void openNewForm(Form f)
        {
            f.ShowDialog();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }     
        private void readFromFile()
        { 
            amount = file.ReadFromFile(dirOfAmount);

            vacuum.amount = amount[0];
            phone.amount = amount[1];
            headphone.amount = amount[2];
        }
    }
}
