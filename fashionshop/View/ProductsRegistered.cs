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
            optionsFilter();
            cmbActive.SelectedIndex = 0;

        }

        public void optionsFilter()
        {
            string[] options = ["ativos", "desativados", "todos"];
            foreach (string option in options)
            {
                cmbActive.Items.Add(option);
            }
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


            ArrayList rows = new ArrayList();
            if (cmbActive.SelectedIndex == 0)
            {
                rows = this.productController.listActiveProducts();
            }
            if (cmbActive.SelectedIndex == 1)
            {
                rows = this.productController.listInactiveProducts();
            }
            if (cmbActive.SelectedIndex == 2)
            {
                rows = this.productController.listAllProducts();
            }

            foreach (string[] product in rows)
            {
                int index = dgvProducts.Rows.Add(product);
                if (cmbActive.SelectedIndex == 2 && product[7] == "False")
                {
                    dgvProducts.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    dgvProducts.Rows[index].DefaultCellStyle.ForeColor = Color.Snow;
                }
               
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

                string active;
                if (this.productController.GetOneByBarcode(codBarras)[5] == "True")
                {
                    active = "ativado";
                }
                else
                {
                    active = "desativado";
                }
                EditProduct editProduct = new EditProduct(product, active, id);



                if (editProduct.ShowDialog() == DialogResult.OK)
                {
                    productController.UpdateItem(id, editProduct.editingProduct());
                }

            }
            btnRefresh.PerformClick();

        }

        private void cmbActive_SelectedValueChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedLine = dgvProducts.SelectedRows[0];

                string id = selectedLine.Cells[0].Value.ToString();


                if (MessageBox.Show(
                    "Deseja realmente inativar produto?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    productController.ChangeStatus(id, 0);
                }



            }
            btnRefresh.PerformClick();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
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


            ArrayList rows = new ArrayList();
            if (txtSearch.Text.Length > 0)
            {
                if (cmbActive.SelectedIndex == 0)
                {
                    rows = this.productController.GetByDescription(txtSearch.Text, 1);
                }
                if (cmbActive.SelectedIndex == 1)
                {
                    rows = this.productController.GetByDescription(txtSearch.Text, 0);
                }
                if (cmbActive.SelectedIndex == 2)
                {
                    rows = this.productController.GetAllByDescription(txtSearch.Text);
                }

            }
            else
            {
                if (cmbActive.SelectedIndex == 0)
                {
                    rows = this.productController.listActiveProducts();
                }
                if (cmbActive.SelectedIndex == 1)
                {
                    rows = this.productController.listInactiveProducts();
                }
                if (cmbActive.SelectedIndex == 2)
                {
                    rows = this.productController.listAllProducts();
                }
            }


            foreach (string[] product in rows)
            {
                dgvProducts.Rows.Add(product);
            }

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointOfSale form = new PointOfSale();
            form.ShowDialog();
            this.Show();
            btnRefresh_Click(sender, e);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders form = new Orders();
            form.ShowDialog();
            this.Show();
        }
    }
}
