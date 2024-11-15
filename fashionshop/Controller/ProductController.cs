using System;
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

        public void RegisterItem(Product product)
        {
            try
            {
                productService.SaveProduct(product);
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
                productService.EditProduct(idProduct,product);
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
    }
}
