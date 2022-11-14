using ShopProductsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsList
{
    internal class FileSave
    {
        public static void ListToFile(List<Product> list, string path)
        {
            StreamWriter sw = new StreamWriter(path,false);
            if(list != null)
            {
                foreach (Product product in list)
                {
                    string tmp = product.Name + "\n";
                    tmp += @$"{product.Description.Replace("\n", "\\n")}" + "\n";
                    tmp += product.PriceNb + "\n";
                    tmp += product.Quantity + "\n";
                    sw.Write(tmp);
                }
            }
            sw.Close();
        }
    }
}
