using fashionshop.Model.Product;
using System;
using System.Collections.Generic;
using System.Collections;

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
                Product product = null;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos WHERE codBarras = @barcode";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        MySqlDataReader item = cmd.ExecuteReader();

                        if(item.Read())
                        {
                            string description = item["descricao"].ToString();
                            string category = item["categoria"].ToString();
                            string brand = item["marca"].ToString();
                            decimal price = Convert.ToDecimal(item["preco"]);
                            
                            product = new Product(barcode, description, category, brand, price);

                        }
                        return product;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }

        //public void inactivate(int productId)
        //{

        //}
        public void update(string productId, Product product)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                { 
                    var query = @"UPDATE produtos 
                                SET codBarras = @codBarras, 
                                    descricao = @descricao, 
                                    categoria = @categoria, 
                                    marca = @marca, 
                                    preco = @preco 
                                WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@codBarras", product.BarCode);
                        cmd.Parameters.AddWithValue("@descricao", product.Description);
                        cmd.Parameters.AddWithValue("@categoria", product.Category);
                        cmd.Parameters.AddWithValue("@marca", product.Brand);
                        cmd.Parameters.AddWithValue("@preco", product.Price);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt16(productId));


                        cmd.ExecuteNonQuery();

                    }
                    con.CloseConnection(conection);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update product to the database: " + ex.Message);
            }
        }
        //public Product findOne(string productId)
        //{

        //}

        public ArrayList findAll()
        {
            try
            {
                ArrayList rows = new ArrayList();
                string[] register;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        
                        MySqlDataReader item = cmd.ExecuteReader();

                        while (item.Read())
                        {
                            register = new string[]
                            {
                                item["id"].ToString(),
                                item["codBarras"].ToString(),
                                item["descricao"].ToString(),
                                item["categoria"].ToString(),
                                item["marca"].ToString(),
                                item["preco"].ToString(),
                                item["estoque"].ToString()
                            };

                            rows.Add(register);

                        }
                        return rows;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }
        //public List<Product> findByDescription(string description)
        //{

        //}


      
    }
}
