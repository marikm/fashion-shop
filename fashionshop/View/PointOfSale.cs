using fashionshop.Controller;
using fashionshop.Service;
using System;
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
    public partial class PointOfSale : Form
    {
        private readonly ProductController productController;
        private readonly ProductService productService;

        public PointOfSale()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();
            txtQnt.Text = "1";
            txtTotalValue.Text = "0";
            txtBarcode.Focus();
        }


        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    if (this.productController.GetByBarcode(txtBarcode.Text)[5] == "True")
                    {
                        string description = this.productController.GetByBarcode(txtBarcode.Text)[1];
                        string itemValue = this.productController.GetByBarcode(txtBarcode.Text)[4];
                        int total = Convert.ToInt16(itemValue) * Convert.ToInt16(txtQnt.Text);
                        string totalItem = Convert.ToString(total);
                        txtDescription.Text = description;
                        txtUnItemValue.Text = itemValue;
                        txtTotalItemValue.Text = totalItem;

                        dgvSale.ColumnCount = 5;

                        dgvSale.Columns[0].Name = "cod. Barras";
                        dgvSale.Columns[0].Width = 80;
                        dgvSale.Columns[1].Name = "descrição";
                        dgvSale.Columns[1].Width = 200;
                        dgvSale.Columns[2].Name = "qnt";
                        dgvSale.Columns[2].Width = 30;
                        dgvSale.Columns[3].Name = "valor un";
                        dgvSale.Columns[3].Width = 60;

                        dgvSale.Columns[4].Name = "valor total";

                        string[] item = [txtBarcode.Text, description, txtQnt.Text, itemValue, totalItem];

                        dgvSale.Rows.Add(item);

                        int totalValue = Convert.ToInt16(txtTotalValue.Text) + total;

                        txtTotalValue.Text = totalValue.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Produto inativo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Favor informar código de barras", "Atenção", MessageBoxButtons.OK);
                }

            }
        }

        private void txtQnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    if (this.productController.GetByBarcode(txtBarcode.Text)[5] == "True")
                    {
                        string description = this.productController.GetByBarcode(txtBarcode.Text)[1];
                        string itemValue = this.productController.GetByBarcode(txtBarcode.Text)[4];
                        int total = Convert.ToInt16(itemValue) * Convert.ToInt16(txtQnt.Text);
                        string totalItem = Convert.ToString(total);
                        txtDescription.Text = description;
                        txtUnItemValue.Text = itemValue;
                        txtTotalItemValue.Text = totalItem;

                        dgvSale.ColumnCount = 5;

                        dgvSale.Columns[0].Name = "cod. Barras";
                        dgvSale.Columns[0].Width = 80;
                        dgvSale.Columns[1].Name = "descrição";
                        dgvSale.Columns[1].Width = 200;
                        dgvSale.Columns[2].Name = "qnt";
                        dgvSale.Columns[2].Width = 30;
                        dgvSale.Columns[3].Name = "valor un";
                        dgvSale.Columns[3].Width = 60;

                        dgvSale.Columns[4].Name = "valor total";

                        string[] item = [txtBarcode.Text, description, txtQnt.Text, itemValue, totalItem];

                        dgvSale.Rows.Add(item);

                        int totalValue = Convert.ToInt16(txtTotalValue.Text) + total;

                        txtTotalValue.Text = totalValue.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Produto inativo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Favor informar código de barras", "Atenção", MessageBoxButtons.OK);
                }

            }
        }
    }
}
