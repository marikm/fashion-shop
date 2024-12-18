﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionshop.Service;
using fashionshop.Model.Product;


namespace fashionshop.Controller
{
    public class ProductController
    {
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        public void RegisterItem(Product product, string stock)
        {
            try
            {
                productService.SaveProduct(product, stock);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateItem(string idProduct, Product product)
        {
            try
            {
                productService.EditProduct(idProduct, product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ArrayList listAllProducts()
        {
            return productService.GetAllProducts();
        }

        public ArrayList listActiveProducts()
        {
            return productService.GetActiveProducts();
        }

        public ArrayList listInactiveProducts()
        {
            return productService.GetInactiveProducts();
        }

        public void ChangeStatus(string id, int status)
        {
            try
            {
                productService.ChangeStatus(id, status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string[] GetOneByBarcode(string barcode)
        {
            return productService.GetProductByBarcode(barcode);
        }

        public ArrayList GetByDescription(string description, int status)
        {
            return this.productService.GetByDescription(description, status);
        }

        public ArrayList GetAllByDescription(string description)
        {
            return this.productService.GetAllProductsByDescription(description);
        }

        public string[] GetByBarcode(string barcode)
        {
            return productService.GetOneByBarcode(barcode);
        }
        public void setStock(string barcode, int qnt)
        {
            this.productService.setStock(barcode, qnt);
        }

        public void setOrder(string totalValue)
        {
            this.productService.setOrder(totalValue);
        }
        public ArrayList ListOrders()
        {
            return this.productService.ListOrders();
        }
        public void setOrderItem(string[] item)
        {
            this.productService.setOrderItem(item);
        }

        public ArrayList ListOrderDetails(string npedido)
        {
            return this.productService.ListOrderDetails(npedido);
        }
    }
}
