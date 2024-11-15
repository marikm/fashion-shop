﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionshop.Repository;
using fashionshop.Model.Product;
using fashionshop.Database;


namespace fashionshop.Service
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;
        private Connection con = new Connection();

        public ProductService()
        {
            this.productRepository = new ProductMySqlRepository(con);
        }

        public bool ProductExists(string barCode)
        {
            if (this.productRepository.findByBarcode(barCode) != null)
            {
                return true;
            }
            return false;
        }

        public void SaveProduct(Product item)
        {
            if(ProductExists(item.BarCode))
            {
                throw new Exception("Barcode informed already registered in database");
            }
            
            productRepository.save(item);
        }

        public ArrayList GetAllProducts()
        {
            return this.productRepository.findAll();

        }

        public void EditProduct(string idProduct, Product item)
        {
            

            this.productRepository.update(idProduct, item);
        }

    }
}
