using System;
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

        public string[] GetProductByBarcode(string barcode)
        {
            return productRepository.findOneByBarcode(barcode);
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
            if (ProductExists(item.BarCode))
            {
                throw new Exception("Código de barras informado já está cadastrado na base de dados");
            }

            productRepository.save(item);
        }

        public ArrayList GetAllProducts()
        {
            return this.productRepository.findAll();

        }
        public ArrayList GetActiveProducts()
        {
            return this.productRepository.findAllActiveProducts();

        }

        public ArrayList GetInactiveProducts()
        {
            ArrayList allProducts = this.productRepository.findAll();
            ArrayList inactivedProducts = new ArrayList();

            foreach (string[] product in allProducts)
            {
                if (product[7] == "False")
                {
                    inactivedProducts.Add(product);
                }
            }

            return inactivedProducts;
        }

        public void EditProduct(string idProduct, Product item)
        {
            this.productRepository.update(idProduct, item);
        }

        public void ChangeStatus(string idProduct, int status)
        {
            this.productRepository.ChangeStatus(idProduct, status);
        }

        public ArrayList GetByDescription(string description, int status)
        {
            return this.productRepository.findByDescription(description, status);
        }

        public ArrayList GetAllProductsByDescription(string description)
        {
            return this.productRepository.findAllByDescription(description);
        }

        public string[] GetOneByBarcode(string barcode)
        {
            return this.productRepository.findOneByBarcode(barcode);
        }

    }
}
