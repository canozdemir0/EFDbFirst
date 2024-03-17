namespace EFDbFirst.Forms
{
    partial class FrmAddProducts
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
            btnAdd = new Button();
            txtStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtName = new TextBox();
            cmbCategories = new ComboBox();
            lblUnitInStock = new Label();
            lblUnitPrice = new Label();
            lblName = new Label();
            lblCategory = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(135, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 31);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(133, 148);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 16;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(133, 112);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(121, 23);
            txtUnitPrice.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 14;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(133, 40);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 13;
            // 
            // lblUnitInStock
            // 
            lblUnitInStock.AutoSize = true;
            lblUnitInStock.Location = new Point(39, 147);
            lblUnitInStock.Name = "lblUnitInStock";
            lblUnitInStock.Size = new Size(77, 15);
            lblUnitInStock.TabIndex = 12;
            lblUnitInStock.Text = "Unit In Stock:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(39, 112);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(61, 15);
            lblUnitPrice.TabIndex = 11;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(39, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 10;
            lblName.Text = "Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(39, 40);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category:";
            // 
            // FrmAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtName);
            Controls.Add(cmbCategories);
            Controls.Add(lblUnitInStock);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblName);
            Controls.Add(lblCategory);
            Name = "FrmAddProducts";
            Text = "FrmAddProducts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtStock;
        private TextBox txtUnitPrice;
        private TextBox txtName;
        private ComboBox cmbCategories;
        private Label lblUnitInStock;
        private Label lblUnitPrice;
        private Label lblName;
        private Label lblCategory;
    }
}