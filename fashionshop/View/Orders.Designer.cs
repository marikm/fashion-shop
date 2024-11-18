namespace fashionshop.View
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrders = new DataGridView();
            label1 = new Label();
            btnDetails = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToOrderColumns = true;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(49, 143);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.ShowEditingIcon = false;
            dgvOrders.Size = new Size(667, 224);
            dgvOrders.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 77);
            label1.TabIndex = 9;
            label1.Text = "Pedidos Realizados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDetails
            // 
            btnDetails.Font = new Font("Segoe UI", 15F);
            btnDetails.Location = new Point(49, 394);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(131, 44);
            btnDetails.TabIndex = 10;
            btnDetails.Text = "detalhes";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(49, 91);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 31);
            btnBack.TabIndex = 11;
            btnBack.Text = "<< Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDetails);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Name = "Orders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
        private Label label1;
        private Button btnDetails;
        private Button btnBack;
    }
}