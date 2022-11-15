using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsList.Models
{
    public class Product
    {
        Guid id;
        string name;
        string description;
        decimal price;
        int quantity;
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        public string Name 
        { 
            get 
            { 
                return name; 
            }
            set
            {
                name = value;
            }
        }
        public string Description 
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
        public int QuantityNb
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public decimal PriceNb
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public Product(string name, string description, decimal price, int quantity)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
