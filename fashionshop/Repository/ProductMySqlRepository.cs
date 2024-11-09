using fashionshop.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using fashionshop.Database;

namespace fashionshop.Repository
{
    public class ProductMySqlRepository : ProductRepository
    {
        private readonly Connection con;

        public ProductMySqlRepository(Connection con)
        {
            this.con = con;
        }

        public void save(Product product)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "INSERT INTO produtos (codBarras, descricao, categoria, marca, preco) " +
                        "VALUES (@codBarras, @descricao, @categoria, @marca, @preco)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("codBarras", product.BarCode);
                        cmd.Parameters.AddWithValue("descricao", product.Description);
                        cmd.Parameters.AddWithValue("categoria", product.Category);
                        cmd.Parameters.AddWithValue("marca", product.Brand);
                        cmd.Parameters.AddWithValue("preco", product.Price);

                        cmd.ExecuteNonQuery();
                    }

                    con.CloseConnection(conection);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to save product to the database");
            }

        }

        public Product findByBarcode(string barcode)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos WHERE codBarras = @barcode";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        MySqlDataReader item = cmd.ExecuteReader();
                        item.Read();

                        string description = item["descricao"].ToString();
                        string category = item["categoria"].ToString();
                        string brand = item["marca"].ToString();
                        decimal price = Convert.ToDecimal(item["preco"]);
                        Product obj = new Product(barcode, description, category, brand, price);

                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find item in database: " + ex.Message);
            }
        }

        //public void inactivate(int productId)
        //{

        //}
        //public void update(int productId)
        //{

        //}
        //public Product findOne(string productId)
        //{

        //}

        //public List<Product> findAll()
        //{

        //}
        //public List<Product> findByDescription(string description)
        //{

        //}


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
