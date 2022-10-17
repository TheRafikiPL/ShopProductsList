using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsList.Models
{
    public class Product
    {
        string name;
        string description;
        decimal price;
        int quantity;
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
        }
        public string Description 
        {
            get
            {
                return description;
            }
        }
        public string Price
        {
            get
            {
                return price.ToString()+" zł";
            }
        }
        public string Quantity
        {
            get 
            {
                return quantity.ToString(); 
            }
        }

        public Product(string name, string description, decimal price, int quantity)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
