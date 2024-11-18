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
        void updateStock(string barcode, int qnt);
        public void ChangeStatus(string productId, int status);
        void update(string productId, Product product);
        string[] findOneByBarcode(string barcode);
        Product findByBarcode(string barcode);
        ArrayList findAll();
        ArrayList findAllActiveProducts();
        ArrayList findByDescription(string description, int status);
        ArrayList findAllByDescription(string description);
        void setOrder(string totalValue);
        void setOrderItem(string[] item);
        ArrayList ListOrders();

    }
}
