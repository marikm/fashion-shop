namespace fashionshop.View
{
    partial class OrderDetails
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
            dgvOrderDetails = new DataGridView();
            label = new Label();
            txtOrder = new TextBox();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTotalValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(29, 167);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(575, 271);
            dgvOrderDetails.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("MS Reference Sans Serif", 9F);
            label.Location = new Point(624, 163);
            label.Name = "label";
            label.Size = new Size(70, 16);
            label.TabIndex = 26;
            label.Text = "Nº pedido";
            // 
            // txtOrder
            // 
            txtOrder.Font = new Font("Segoe UI", 12F);
            txtOrder.Location = new Point(624, 192);
            txtOrder.Name = "txtOrder";
            txtOrder.ReadOnly = true;
            txtOrder.Size = new Size(113, 29);
            txtOrder.TabIndex = 25;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(29, 128);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 31);
            btnBack.TabIndex = 27;
            btnBack.Text = "<< Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(758, 77);
            label1.TabIndex = 28;
            label1.Text = "Detalhes do pedido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F);
            label2.Location = new Point(624, 380);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 30;
            label2.Text = "Valor Total";
            // 
            // txtTotalValue
            // 
            txtTotalValue.Font = new Font("Segoe UI", 12F);
            txtTotalValue.Location = new Point(624, 409);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(113, 29);
            txtTotalValue.TabIndex = 29;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(label2);
            Controls.Add(txtTotalValue);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(label);
            Controls.Add(txtOrder);
            Controls.Add(dgvOrderDetails);
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetails;
        private Label label;
        private TextBox txtOrder;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private TextBox txtTotalValue;
    }
}