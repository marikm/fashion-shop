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
    public partial class Orders : Form
    {
        private readonly ProductController productController;
        private readonly ProductService productService;
        public Orders()
        {
            this.productService = new ProductService();
            this.productController = new ProductController(this.productService);
            InitializeComponent();
            LoadOrders();
        }
        public void LoadOrders()
        {
            ArrayList list = this.productController.ListOrders();
            dgvOrders.Rows.Clear();

            dgvOrders.ColumnCount = 2;
            dgvOrders.Columns[0].Name = "n. pedido";
            dgvOrders.Columns[1].Name = "valor total";

            foreach (string[] item in list)
            {
                dgvOrders.Rows.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedLine = dgvOrders.SelectedRows[0];
            string idPedido = selectedLine.Cells[0].Value.ToString();
            OrderDetails details = new OrderDetails();
            details.LoadOrderDetails(idPedido);
            this.Hide();
            details.ShowDialog();
            this.Show();

        }
    }

}
