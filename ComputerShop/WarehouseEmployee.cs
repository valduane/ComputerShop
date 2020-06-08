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
    public partial class WarehouseEmployee : Form
    {
        string currentProduct;
        string text;
        string textToWriteFile;
        string dir = @"C:\Users\valduane\Desktop\amountOfProduct.txt";
        SaveAndLoadFile file = new SaveAndLoadFile();
        Form1 f = new Form1();
        Product vacuumProd;
        Product phoneProd;
        Product headphoneProd;
        public WarehouseEmployee()
        {
            InitializeComponent();
            vacuumProd = f.GetVacuumObj();
            phoneProd = f.GetPhoneObj();
            headphoneProd = f.GetHeadphoneObj();
        }

        private void vacuum_Click(object sender, EventArgs e)
        {
            text = "Вертикальный пылесос STARWIND SCH1010 кол-во = " + vacuumProd.amount;
            showText(text);
            currentProduct = "vacuum";
        }

        private void phone_Click(object sender, EventArgs e)
        {
            text = "Смартфон Huawei P40 128 ГБ серебристый кол-во = " + phoneProd.amount;
            showText(text);
            currentProduct = "phone";
        }

        private void headphones_Click(object sender, EventArgs e)
        {
            text = "Наушники беспроводные TCL ELIT400BT кол-во = " + headphoneProd.amount;
            showText(text);
            currentProduct = "headphone";
        }
        private void showText(string text)
        {
            information.Text = text;
        }

        private void inc_Click(object sender, EventArgs e)
        {
            if (currentProduct == "vacuum")
            {
                vacuumProd.amount++;
            }
            else if(currentProduct == "phone")
            {
                phoneProd.amount++;
            }
            else if(currentProduct == "headphone")
            {
                headphoneProd.amount++;
            }
            textToWriteFile = vacuumProd.amount + " " + phoneProd.amount + " " + headphoneProd.amount;
            file.SaveToFile(dir, textToWriteFile);
        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (currentProduct == "vacuum")
            {
                vacuumProd.amount--;
            }
            else if (currentProduct == "phone")
            {
                phoneProd.amount--;
            }
            else if (currentProduct == "headphone")
            {
                headphoneProd.amount--;
            }
            textToWriteFile = vacuumProd.amount + " " + phoneProd.amount + " " + headphoneProd.amount;
            file.SaveToFile(dir, textToWriteFile);
        }
    }
}
