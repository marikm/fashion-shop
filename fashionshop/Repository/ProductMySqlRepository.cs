﻿using fashionshop.Model.Product;
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

        public void save(Product product, string stock)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "INSERT INTO produtos (codBarras, descricao, categoria, marca, preco, estoque) " +
                        "VALUES (@codBarras, @descricao, @categoria, @marca, @preco, @estoque)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("codBarras", product.BarCode);
                        cmd.Parameters.AddWithValue("descricao", product.Description);
                        cmd.Parameters.AddWithValue("categoria", product.Category);
                        cmd.Parameters.AddWithValue("marca", product.Brand);
                        cmd.Parameters.AddWithValue("preco", product.Price);
                        cmd.Parameters.AddWithValue("estoque", stock);

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

                        if (item.Read())
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

        public void ChangeStatus(string productId, int status)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    var query = @"UPDATE produtos SET ativo = @ativo WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        if (status == 0)
                        {
                            cmd.Parameters.AddWithValue("@ativo", false);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ativo", true);
                        }
                        cmd.Parameters.AddWithValue("@id", productId);

                        cmd.ExecuteNonQuery();
                    }
                    con.CloseConnection(conection);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
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
        public string[] findOneByBarcode(string barcode)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    string[] product = null;
                    var query = "SELECT * FROM produtos WHERE codBarras = @barcode";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        MySqlDataReader item = cmd.ExecuteReader();

                        while (item.Read())
                        {
                            product = new string[]
                            {
                                 item["codBarras"].ToString(),
                                 item["descricao"].ToString(),
                                 item["categoria"].ToString(),
                                 item["marca"].ToString(),
                                 item["preco"].ToString(),
                                 item["ativo"].ToString(),
                                 item["estoque"].ToString()
                            };

                        }
                    }
                    return product;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }

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
                                item["estoque"].ToString(),
                                item["ativo"].ToString()
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

        public ArrayList findAllActiveProducts()
        {
            try
            {
                ArrayList rows = new ArrayList();
                string[] register;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos WHERE ativo=1";
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

        public ArrayList findByDescription(string description, int status)
        {
            try
            {
                ArrayList rows = new ArrayList();
                string[] register;


                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos WHERE ativo=@status AND descricao LIKE CONCAT('%', @descricao, '%')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@descricao", description);
                        cmd.Parameters.AddWithValue("@status", status);

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
                    }
                    return rows;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }

        public ArrayList findAllByDescription(string description)
        {
            try
            {
                ArrayList rows = new ArrayList();
                string[] register;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM produtos WHERE descricao LIKE CONCAT('%', @descricao, '%')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@descricao", description);

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
                    }
                    return rows;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }

        public void updateStock(string barcode, int qnt)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    int dbStock = Convert.ToInt16(this.findOneByBarcode(barcode)[6]);
                    int newStock = dbStock + qnt;

                    var query = @"UPDATE produtos 
                                SET estoque = @estoque 
                                WHERE codBarras = @codBarras";

                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("@codBarras", barcode);
                        cmd.Parameters.AddWithValue("@estoque", Convert.ToString(newStock));

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
        public void setOrder(string totalValue)
        {
            try
            {
                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "INSERT INTO pedido (valorTotal) " +
                        "VALUES (@valorTotal)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("valorTotal", totalValue );
                        
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
        public void setOrderItem(string[] item)
        {
            try
            {
                string idOrder;
                using (MySqlConnection conection = con.getConnection())
                {
                    string selectIdQuery = "SELECT MAX(id) FROM pedido";
                    using (MySqlCommand cmd = new MySqlCommand(selectIdQuery, conection))
                    {
                        idOrder = cmd.ExecuteScalar().ToString();

                        cmd.ExecuteNonQuery();
                    }

                    var query = "INSERT INTO pedidoitens (npedido, codBarras, descricao, quantidade, valorUn, itemTotal) " +
                        "VALUES (@npedido, @codBarras, @descricao, @quantidade, @valorUn, @itemTotal)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("npedido", idOrder);
                        cmd.Parameters.AddWithValue("codBarras", item[0]);
                        cmd.Parameters.AddWithValue("descricao", item[1]);
                        cmd.Parameters.AddWithValue("quantidade", item[2]);
                        cmd.Parameters.AddWithValue("valorUn", item[3]);
                        cmd.Parameters.AddWithValue("itemTotal", item[4]);

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

        public ArrayList ListOrders()
        {
            try
            {
                ArrayList rows = new ArrayList();
                string[] register;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM pedido";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {

                        MySqlDataReader item = cmd.ExecuteReader();
                        
                        while (item.Read())
                        {
                            register = new string[]
                            {
                                item["id"].ToString(),
                                item["valorTotal"].ToString()
                                
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

        public ArrayList ListOrderDetails(string npedido)
        {
            try
            {
                ArrayList order = new ArrayList();
                string[] register;

                using (MySqlConnection conection = con.getConnection())
                {
                    var query = "SELECT * FROM pedidoitens WHERE npedido=@npedido";
                    using (MySqlCommand cmd = new MySqlCommand(query, conection))
                    {
                        cmd.Parameters.AddWithValue("npedido", npedido);
                        MySqlDataReader item = cmd.ExecuteReader();

                        while (item.Read())
                        {
                            register = new string[]
                            {
                                item["id"].ToString(),
                                item["npedido"].ToString(),
                                item["codBarras"].ToString(),
                                item["descricao"].ToString(),
                                item["quantidade"].ToString(),
                                item["valorUn"].ToString(),
                                item["itemTotal"].ToString()

                            };
                            order.Add(register);
                        }


                    }
                }
                return order;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to find in Read() method: " + ex.Message);
            }
        }


    }
}
