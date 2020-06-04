using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerShop
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        Order order = new Order();
        int productPrice = 0;
        float coef = 0;
        SaveAndLoadFile file = new SaveAndLoadFile();
        string dir = @"C:\Users\valduane\Desktop\orders.txt";
        public Form3(int prodPrice, string curProd)
        {
            InitializeComponent();
            string text = "ID заказа: ";
            int id = random.Next(1000);
            information.Text = text + id;
            productPrice = prodPrice;
            order.orderID = id;
            order.orderPrice = prodPrice;
            order.prodName = curProd;
            showPrice();
        }
        private void information_Click(object sender, EventArgs e)
        {
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                order.orderPrice = order.orderPrice - 500;
            }
            else if(checkBox1.Checked)
            {
                order.orderPrice = order.orderPrice + 500;
            }
            showPrice();
        }

        private void price_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            coef = 0.2f * productPrice;
            if (!checkBox2.Checked)
            {
                order.orderPrice = order.orderPrice - coef;
            }
            else if (checkBox2.Checked)
            {
                order.orderPrice = order.orderPrice + coef;
            }
            showPrice();
        }

        private void showPrice()
        {
            price.Text = "Общая стоимость: " + order.orderPrice;
        }

        private void orderFinaly_Click(object sender, EventArgs e)
        {
            order.status = true;
            file.SaveToFile(dir, order);
        }
    }
}
 