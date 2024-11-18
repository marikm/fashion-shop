using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fashionshop.Controller;
using fashionshop.Model.Product;
using fashionshop.Service;

namespace fashionshop.View
{
    public partial class EditProduct : Form
    {
        private readonly ProductService productService;
        private readonly ProductController productController;

        string id;
        string BarCode { get; set; }
        string Description { get; set; }
        string Brand { get; set; }
        string Category { get; set; }
        string Price { get; set; }
        public string Active { get; set; }
        public EditProduct(Product product, string active, string id)
        {
            InitializeComponent();
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            this.id = id;
            optionsStatus();

            txtBarcode.Text = product.BarCode;
            txtDescription.Text = product.Description;
            cmbBrand.Text = product.Brand;
            cmbCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString();
            cmbActive.Text = active;
        }

        public void optionsStatus()
        {
            string[] items = { "ativado", "desativado" };
            cmbActive.Items.Add(items[0]);
            cmbActive.Items.Add(items[1]);

        }
        public Product editingProduct()
        {
            try
            {
                this.BarCode = txtBarcode.Text;
                this.Description = txtDescription.Text;
                this.Category = cmbCategory.Text;
                this.Brand = cmbBrand.Text;
                this.Price = txtPrice.Text;
                Product productEdit = new Product(this.BarCode, this.Description, this.Category, this.Brand, Convert.ToDecimal(this.Price));

                return productEdit;

            }
            catch (Exception ex)
            {
                throw new Exception("productEdit not created");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.editingProduct();
            if (cmbActive.Text == "desativado")
            {
                productController.ChangeStatus(id, 0);
            }
            else
            {
                productController.ChangeStatus(id, 1);

            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar edição?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
