using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fashionshop.Model.Product;
using fashionshop.Controller;
using fashionshop.Service;



namespace fashionshop.View
{
    public partial class RegisterProduct : Form
    {
        private readonly ProductController productController;
        private readonly ProductService productService;

        public RegisterProduct()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string barCode = txtBarcode.Text;
            string description = txtDescription.Text;
            string category = cmbCategory.Text;
            string brand = cmbBrand.Text;
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = "0";
            }
            decimal price = decimal.Parse(txtPrice.Text);
            try
            {
                Product item = new(barCode, description, category, brand, price);
                productController.RegisterItem(item);
                MessageBox.Show(
                    "Product saved in database", 
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
