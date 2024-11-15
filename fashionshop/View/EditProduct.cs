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
        string BarCode { get; set; }
        string Description { get; set; }
        string Brand { get; set; }
        string Category { get; set; }
        string Price { get; set; }
        public EditProduct(Product product)
        {
            InitializeComponent();
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            txtBarcode.Text = product.BarCode;
            txtDescription.Text = product.Description;
            cmbBrand.Text = product.Brand;
            cmbCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString();
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
                Product productEdit = new Product(this.BarCode, this.Description, this.Brand, this.Category, Convert.ToDecimal(this.Price));

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
            //MessageBox.Show("produto salvo", "info", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }


    }
}
