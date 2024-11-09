using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionshop.Model.Product
{
    public class Product
    {
        private readonly string barCode;
        private readonly String description;
        private readonly String category;
        private readonly String brand;
        private readonly decimal price;

        public Product(string barCode, string description, string category, string brand, decimal price)
        {
            if (string.IsNullOrWhiteSpace(barCode)){ throw new Exception("BarCode is null or empty.");}
            if (string.IsNullOrWhiteSpace(description)) throw new Exception("Description is null or empty");
            if (string.IsNullOrWhiteSpace(category)) throw new Exception("Category is null or empty");
            if (string.IsNullOrWhiteSpace(brand)) throw new Exception("Brand is null or empty");
            if (price <= 0) throw new Exception("Price value invalid: zero or negative");
            this.barCode = barCode;
            this.description = description;
            this.category = category;
            this.brand = brand;
            this.price = price;
            
        }

        public string BarCode => barCode;

        public string Description => description;

        public string Category => category;

        public string Brand => brand;

        public decimal Price => price;


    }



}
