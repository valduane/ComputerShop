using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComputerShop
{
    class SaveAndLoadFile
    {
        public void SaveToFile(string dir, Order order)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(dir, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(order.prodName);
                    sw.WriteLine(order.orderID);
                    sw.WriteLine(order.orderPrice);
                    sw.WriteLine(order.status);
                    sw.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveToFile(string dir, string text)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(dir, false, System.Text.Encoding.Default))
                {
                    sw.Write(text);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int[] ReadFromFile(string dir)
        {
            string line = "";
            int a = 0;
            int[] array = new int [3];
            try
            {
                using (StreamReader sr = new StreamReader(dir))
                {
                    line = sr.ReadLine();
                    array = line.Split(' ').Select(Int32.Parse).ToArray();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return array;
        }
    }
}
