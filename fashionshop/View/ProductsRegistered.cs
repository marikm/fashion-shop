using fashionshop.Controller;
using fashionshop.Service;
using fashionshop.Model.Product;

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionshop.View
{
    public partial class ProductsRegistered : Form
    {
        private readonly ProductService productService;
        private readonly ProductController productController;

        public ProductsRegistered()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();


        }
        private void ProductsRegistered_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterProduct form = new RegisterProduct();
            form.ShowDialog();
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ArrayList rows = this.productController.listAllProducts();

            dgvProducts.Rows.Clear();

            dgvProducts.ColumnCount = 7;
            dgvProducts.Columns[0].Name = "id";
            dgvProducts.Columns[1].Name = "cod. Barras";
            dgvProducts.Columns[2].Name = "descrição";
            dgvProducts.Columns[2].Width = 300;
            dgvProducts.Columns[3].Name = "categoria";
            dgvProducts.Columns[4].Name = "marca";
            dgvProducts.Columns[5].Name = "valor";
            dgvProducts.Columns[6].Name = "estoque";

            foreach (string[] product in rows)
            {
                dgvProducts.Rows.Add(product);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedLine = dgvProducts.SelectedRows[0];

                string id = selectedLine.Cells[0].Value.ToString();
                string codBarras = selectedLine.Cells[1].Value.ToString();
                string description = selectedLine.Cells[2].Value.ToString();
                string category = selectedLine.Cells[3].Value.ToString();
                string brand = selectedLine.Cells[4].Value.ToString();
                Decimal price = Convert.ToDecimal(selectedLine.Cells[5].Value);

                Product product = new Product(codBarras, description, category, brand, price);

                EditProduct editProduct = new EditProduct(product);


                if (editProduct.ShowDialog() == DialogResult.OK)
                {
                    productController.UpdateItem(id, editProduct.editingProduct());
                }

            }
            btnRefresh.PerformClick();

        }

    }
}
