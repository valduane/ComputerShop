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
    public partial class Form2 : Form
    {
        Form1 f = new Form1();
        public string currentProduct = " ";
        public int currentPrice = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void vacuum_Click(object sender, EventArgs e)
        {
            string text = "Вертикальный пылесос STARWIND SCH1010 имеет достаточно мощный двигатель - 800 Ватт и поможет за очень короткое время убрать в вашей квартире или рабочем помещении. При необходимости, он легко трансформируется в ручную модель и прекрасно подойдет не только для уборки пола, но и поможет очистить мебель. Благодаря небольшому весу и тщательно сбалансированной конструкции, прибором очень удобно пользоваться, а возможность вертикального хранения избавит от необходимости лишний раз нагибаться. Использование пылесоса не требует покупки дополнительных мешков, поскольку в его комплектацию входит специальный контейнер для пыли, емкостью 0,8 литров. Модель оснащена моющимся фильтром. Устройство работает от сети 220 В. Длинный шнур, 4,5 метра, позволит достать в самые труднодоступные участки помещения. В набор вертикального пылесоса входит одна основная насадка - щетка для пола. Прибор предназначен для сухой чистки и может быть использован как домашних условиях, так и в офисе. Цена - 1999 руб.";
            showText(text);
            currentProduct = "vacuum";
            currentPrice = f.GetVacuumPrice();
        }

        private void phone_Click(object sender, EventArgs e)
        {
            string text = "Смартфон Huawei P40 128 ГБ серебристый - Инновационный процессор Kirin 990 с поддержкой 5G изменит ваши представления о скорости. Ультракамера Ultra Vision Leica с тремя объективами и передовыми возможностями искусственного интеллекта в корне меняет процесс фото- и видеосъемки. Продолжайте изучать мир и создавать свою историю. Ультракамера Leica с тремя объективами работает как единый механизм и всегда готова помочь вам сделать неповторимый снимок в любое время и в любом месте. Запечатлейте то, что видите, и позвольте камере выразить ваши чувства. Цена - 40000 руб.";
            showText(text);
            currentProduct = "phone";
            currentPrice = f.GetPhonePrice();
        }

        private void headphones_Click(object sender, EventArgs e)
        {
            string text = "Наушники беспроводные TCL ELIT400BT были разработаны для тех, кто нуждается в превосходном качестве звука. Модель оснащена эргономичным оголовьем и амбушюрами из пены с эффектом памяти, которые удобно лежат на ушах весь день. Встроенный Bluetooth позволяет вам наслаждаться беспроводным звуком Hi-Res и высококачественным звуком в комфорте. Цена - 5500 руб.";
            showText(text);
            currentProduct = "headphones";
            currentPrice = f.GetHeadphonePrice();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public string GetProduct()
        {
            return currentProduct;
        }
        public int GetPrice()
        {
            return currentPrice;
        }
        private void showText(string text)
        {
            information.Text = text;
        }
        private void order_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(currentPrice, currentProduct);
            f.ShowDialog();
        }

       
    }
}
