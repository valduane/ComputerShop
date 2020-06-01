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
        Order order;
        Form2 f = new Form2();
        public Form3(int prodPrice)
        {
            InitializeComponent();
            string text = "ID заказа: ";
            int id = random.Next(1000);
            information.Text = text + id;

            order = new Order();
            order.orderID = id;
            order.orderPrice = f.GetPrice();

            price.Text = "Общая стоимость: " + order.orderPrice;
        }

        private void information_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
 