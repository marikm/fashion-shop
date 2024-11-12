using System;
using System.Collections.Generic;
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
            return productRepository.findByBarcode(barCode) != null;
        }

        public void SaveProduct(Product item)
        {
            if(!this.ProductExists(item.BarCode))
            {
                productRepository.save(item);
            }
            throw new Exception("Barcode informed already registered in database");
        }
    }
}
