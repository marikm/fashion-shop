﻿namespace fashionshop.View
{
    partial class EditProduct
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
            txtBarcode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            cmbBrand = new ComboBox();
            label5 = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            label6 = new Label();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            cmbActive = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(510, 69);
            label1.TabIndex = 11;
            label1.Text = "Editar Produto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 12F);
            txtBarcode.Location = new Point(19, 55);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(442, 29);
            txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F);
            label2.Location = new Point(19, 36);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 2;
            label2.Text = "Cód. Barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F);
            label3.Location = new Point(19, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 3;
            label3.Text = "Descrição";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(19, 125);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(442, 29);
            txtDescription.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(19, 201);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(159, 29);
            cmbCategory.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 9F);
            label4.Location = new Point(19, 182);
            label4.Name = "label4";
            label4.Size = new Size(69, 16);
            label4.TabIndex = 6;
            label4.Text = "Categoria";
            // 
            // cmbBrand
            // 
            cmbBrand.Font = new Font("Segoe UI", 12F);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(291, 201);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(171, 29);
            cmbBrand.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 9F);
            label5.Location = new Point(291, 182);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 8;
            label5.Text = "Marca";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(291, 281);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 29);
            txtPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(172, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 9F);
            label6.Location = new Point(223, 294);
            label6.Name = "label6";
            label6.Size = new Size(42, 16);
            label6.TabIndex = 10;
            label6.Text = "Preço";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.Location = new Point(331, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbActive);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbBrand);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 404);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // cmbActive
            // 
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.Font = new Font("Segoe UI", 12F);
            cmbActive.FormattingEnabled = true;
            cmbActive.Location = new Point(70, 281);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(108, 29);
            cmbActive.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 9F);
            label7.Location = new Point(19, 288);
            label7.Name = "label7";
            label7.Size = new Size(45, 16);
            label7.TabIndex = 12;
            label7.Text = "ativo?";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 508);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtBarcode;
        private Label label2;
        private Label label3;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private Label label4;
        private ComboBox cmbBrand;
        private Label label5;
        private TextBox txtPrice;
        private Button btnSave;
        private Label label6;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox cmbActive;
    }
}