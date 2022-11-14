using ShopProductsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsList
{
    internal class FileLoad
    {
        public static List<Product> LoadCurrentToList(string path)
        {
            List<Product> list = new List<Product>();
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                string name = sr.ReadLine();
                string desc = sr.ReadLine().Replace("\\n", "\n");
                decimal price = Convert.ToDecimal(sr.ReadLine());
                int quantity = Convert.ToInt32(sr.ReadLine());
                list.Add(new Product(name, desc, price, quantity));
            }
            sr.Close();
            return list;
        }
    }
}
