using System;
using System.Collections;
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
        void update(string productId, Product product);
        //Product findOne(string  productId);
        Product findByBarcode(string barcode);
        ArrayList findAll();
        //List<Product> findByDescription(string description);
    }
}
