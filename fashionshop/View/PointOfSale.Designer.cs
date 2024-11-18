namespace fashionshop.View
{
    partial class PointOfSale
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
            label1 = new Label();
            btnBack = new Button();
            txtDescription = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtBarcode = new TextBox();
            label6 = new Label();
            txtQnt = new TextBox();
            label = new Label();
            txtUnItemValue = new TextBox();
            label5 = new Label();
            txtTotalItemValue = new TextBox();
            dgvSale = new DataGridView();
            txtTotalValue = new TextBox();
            label4 = new Label();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            SuspendLayout();
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
            label1.Text = "VENDAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(12, 102);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 31);
            btnBack.TabIndex = 10;
            btnBack.Text = "<< Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(12, 233);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(299, 29);
            txtDescription.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F);
            label3.Location = new Point(12, 214);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 15;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F);
            label2.Location = new Point(135, 144);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 13;
            label2.Text = "Cód. Barras";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 12F);
            txtBarcode.Location = new Point(135, 163);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(156, 29);
            txtBarcode.TabIndex = 1;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 9F);
            label6.Location = new Point(12, 144);
            label6.Name = "label6";
            label6.Size = new Size(81, 16);
            label6.TabIndex = 20;
            label6.Text = "Quantidade";
            // 
            // txtQnt
            // 
            txtQnt.Font = new Font("Segoe UI", 12F);
            txtQnt.Location = new Point(12, 163);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(113, 29);
            txtQnt.TabIndex = 2;
            txtQnt.KeyDown += txtQnt_KeyDown;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("MS Reference Sans Serif", 9F);
            label.Location = new Point(12, 286);
            label.Name = "label";
            label.Size = new Size(81, 16);
            label.TabIndex = 24;
            label.Text = "Quantidade";
            // 
            // txtUnItemValue
            // 
            txtUnItemValue.Font = new Font("Segoe UI", 12F);
            txtUnItemValue.Location = new Point(12, 305);
            txtUnItemValue.Name = "txtUnItemValue";
            txtUnItemValue.ReadOnly = true;
            txtUnItemValue.Size = new Size(113, 29);
            txtUnItemValue.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 9F);
            label5.Location = new Point(155, 286);
            label5.Name = "label5";
            label5.Size = new Size(91, 16);
            label5.TabIndex = 22;
            label5.Text = "Total do Item";
            // 
            // txtTotalItemValue
            // 
            txtTotalItemValue.Font = new Font("Segoe UI", 12F);
            txtTotalItemValue.Location = new Point(155, 305);
            txtTotalItemValue.Name = "txtTotalItemValue";
            txtTotalItemValue.ReadOnly = true;
            txtTotalItemValue.Size = new Size(156, 29);
            txtTotalItemValue.TabIndex = 21;
            // 
            // dgvSale
            // 
            dgvSale.AllowUserToAddRows = false;
            dgvSale.AllowUserToDeleteRows = false;
            dgvSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new Point(317, 144);
            dgvSale.MultiSelect = false;
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersVisible = false;
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.Size = new Size(471, 243);
            dgvSale.TabIndex = 25;
            // 
            // txtTotalValue
            // 
            txtTotalValue.Font = new Font("Segoe UI", 12F);
            txtTotalValue.Location = new Point(632, 414);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(156, 29);
            txtTotalValue.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 9F);
            label4.Location = new Point(540, 427);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 27;
            label4.Text = "Valor Total";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LightGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 15F);
            btnConfirm.Location = new Point(657, 454);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(131, 44);
            btnConfirm.TabIndex = 28;
            btnConfirm.Text = "Finalizar";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnConfirm);
            Controls.Add(label4);
            Controls.Add(txtTotalValue);
            Controls.Add(dgvSale);
            Controls.Add(label);
            Controls.Add(txtUnItemValue);
            Controls.Add(label5);
            Controls.Add(txtTotalItemValue);
            Controls.Add(label6);
            Controls.Add(txtQnt);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBarcode);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "PointOfSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PointOfSale";
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private TextBox txtDescription;
        private Label label3;
        private Label label2;
        private TextBox txtBarcode;
        private Label label6;
        private TextBox txtQnt;
        private Label label;
        private TextBox txtUnItemValue;
        private Label label5;
        private TextBox txtTotalItemValue;
        private DataGridView dgvSale;
        private TextBox txtTotalValue;
        private Label label4;
        private Button btnConfirm;
    }
}