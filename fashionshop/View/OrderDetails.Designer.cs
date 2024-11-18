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
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(73, 155);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.Size = new Size(646, 199);
            dgvOrderDetails.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("MS Reference Sans Serif", 9F);
            label.Location = new Point(73, 86);
            label.Name = "label";
            label.Size = new Size(70, 16);
            label.TabIndex = 26;
            label.Text = "Nº pedido";
            // 
            // txtOrder
            // 
            txtOrder.Font = new Font("Segoe UI", 12F);
            txtOrder.Location = new Point(73, 105);
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
            btnBack.Location = new Point(73, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 31);
            btnBack.TabIndex = 27;
            btnBack.Text = "<< Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}