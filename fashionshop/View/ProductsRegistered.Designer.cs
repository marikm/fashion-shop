﻿namespace fashionshop.View
{
    partial class ProductsRegistered
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
            label2 = new Label();
            btnRegister = new Button();
            btnEdit = new Button();
            btnDisable = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            txtSearch = new TextBox();
            label3 = new Label();
            dgvProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
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
            label1.Size = new Size(947, 77);
            label1.TabIndex = 8;
            label1.Text = "Produtos Cadastrados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCoral;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 505);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(947, 49);
            label2.TabIndex = 12;
            label2.Text = "Pesquisa";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 15F);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(3, 62);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 60);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.FlatAppearance.BorderColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 15F);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(3, 128);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 60);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDisable
            // 
            btnDisable.BackColor = Color.Transparent;
            btnDisable.FlatAppearance.BorderColor = Color.White;
            btnDisable.FlatStyle = FlatStyle.Flat;
            btnDisable.Font = new Font("Segoe UI", 15F);
            btnDisable.ForeColor = SystemColors.ButtonHighlight;
            btnDisable.Location = new Point(3, 194);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(122, 60);
            btnDisable.TabIndex = 3;
            btnDisable.Text = "Inativar";
            btnDisable.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(3, 260);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 60);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDisable);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnRegister);
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 443);
            panel1.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 522);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(808, 23);
            txtSearch.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCoral;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(931, 77);
            label3.Name = "label3";
            label3.Size = new Size(16, 428);
            label3.TabIndex = 13;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(127, 77);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ScrollBars = ScrollBars.Vertical;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(808, 428);
            dgvProducts.TabIndex = 14;
            // 
            // ProductsRegistered
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 554);
            Controls.Add(dgvProducts);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ProductsRegistered";
            Text = "ProductsRegistered";
            Load += ProductsRegistered_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnRegister;
        private Button btnEdit;
        private Button btnDisable;
        private Button btnRefresh;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label3;
        private DataGridView dgvProducts;
    }
}