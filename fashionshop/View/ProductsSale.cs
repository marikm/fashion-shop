using fashionshop.Controller;
using fashionshop.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionshop.View
{
    public partial class ProductsSale : Form
    {
        private readonly ProductController productController;
        private readonly ProductService productService;
        public ProductsSale()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();
            LoadProducts();
        }

        public void LoadProducts()
        {
            dgvProducts.Rows.Clear();

            dgvProducts.ColumnCount = 7;
            dgvProducts.Columns[0].Name = "id";
            dgvProducts.Columns[1].Name = "cod. Barras";
            dgvProducts.Columns[2].Name = "descrição";
            dgvProducts.Columns[2].Width = 250;
            dgvProducts.Columns[3].Name = "categoria";
            dgvProducts.Columns[4].Name = "marca";
            dgvProducts.Columns[5].Name = "valor";
            dgvProducts.Columns[6].Name = "estoque";


            ArrayList rows = new ArrayList();

            rows = this.productController.listActiveProducts();


            foreach (string[] product in rows)
            {
                dgvProducts.Rows.Add(product);
            }
        }

        public string getBarcode()
        {
            DataGridViewRow selectLine = dgvProducts.SelectedRows[0];
            string barcode = selectLine.Cells[1].Value.ToString();

            return barcode;
        }

        private void dgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Evitar a mudança de linha no DataGridView ao pressionar Enter
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
