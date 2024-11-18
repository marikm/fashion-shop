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
    public partial class OrderDetails : Form
    {
        private readonly ProductService productService;
        private readonly ProductController productController;

        public OrderDetails()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();
        }

        public void LoadOrderDetails(string nOrder)
        {
            txtOrder.Text = nOrder;

            ArrayList list = this.productController.ListOrderDetails(nOrder);
            dgvOrderDetails.Rows.Clear();

            dgvOrderDetails.ColumnCount = 5;
            dgvOrderDetails.Columns[0].Name = "cod. Barras";
            dgvOrderDetails.Columns[1].Name = "descricao";
            dgvOrderDetails.Columns[2].Name = "quantidade";
            dgvOrderDetails.Columns[3].Name = "valor Un";
            dgvOrderDetails.Columns[4].Name = "total item";



            foreach (string[] item in list)
            {
                dgvOrderDetails.Rows.Add(item[2], item[3], item[4], item[5], item[6]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
