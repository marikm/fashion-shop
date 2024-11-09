using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionshop.Model.Product;
using MySql.Data.MySqlClient;

namespace fashionshop.Repository
{
    public interface ProductRepository
    {
        void save(Product product);
        //void inactivate(int productId);
        //void update(int productId);
        //Product findOne(string  productId);
        Product findByBarcode(string barcode);
        //List<Product> findAll();
        //List<Product> findByDescription(string description);
    }
}
