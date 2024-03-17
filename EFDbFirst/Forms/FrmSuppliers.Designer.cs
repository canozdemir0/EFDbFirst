namespace EFDbFirst
{
    partial class FrmSuppliers
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
            dtGridSuppliers = new DataGridView();
            lblSearch = new Label();
            lblTake = new Label();
            txtSearch = new TextBox();
            txtTake = new TextBox();
            btnOrderByCompanyName = new Button();
            btnTake = new Button();
            btnDelete = new Button();
            lblCompanyName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dtGridSuppliers
            // 
            dtGridSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridSuppliers.Location = new Point(12, 144);
            dtGridSuppliers.Name = "dtGridSuppliers";
            dtGridSuppliers.Size = new Size(364, 294);
            dtGridSuppliers.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(176, 35);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(43, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // lblTake
            // 
            lblTake.AutoSize = true;
            lblTake.Location = new Point(340, 37);
            lblTake.Name = "lblTake";
            lblTake.Size = new Size(36, 15);
            lblTake.TabIndex = 2;
            lblTake.Text = "Take:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(224, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 24);
            txtSearch.TabIndex = 3;
            // 
            // txtTake
            // 
            txtTake.Location = new Point(379, 32);
            txtTake.Name = "txtTake";
            txtTake.Size = new Size(100, 24);
            txtTake.TabIndex = 4;
            // 
            // btnOrderByCompanyName
            // 
            btnOrderByCompanyName.Location = new Point(12, 12);
            btnOrderByCompanyName.Name = "btnOrderByCompanyName";
            btnOrderByCompanyName.Size = new Size(156, 60);
            btnOrderByCompanyName.TabIndex = 5;
            btnOrderByCompanyName.Text = "Order By Company Name";
            btnOrderByCompanyName.UseVisualStyleBackColor = true;
            btnOrderByCompanyName.Click += btnOrderByCompanyName_Click;
            // 
            // btnTake
            // 
            btnTake.Location = new Point(537, 12);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(127, 60);
            btnTake.TabIndex = 6;
            btnTake.Text = "Take";
            btnTake.UseVisualStyleBackColor = true;
            btnTake.Click += btnTake_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(13, 94);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(453, 177);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(99, 15);
            lblCompanyName.TabIndex = 8;
            lblCompanyName.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 213);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 9;
            label2.Text = "Contact Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 250);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 10;
            label3.Text = "Contact Title:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(586, 174);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(186, 24);
            txtCompanyName.TabIndex = 11;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(586, 210);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(186, 24);
            txtContactName.TabIndex = 12;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(586, 247);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(186, 24);
            txtContactTitle.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(586, 293);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCompanyName);
            Controls.Add(btnDelete);
            Controls.Add(btnTake);
            Controls.Add(btnOrderByCompanyName);
            Controls.Add(txtTake);
            Controls.Add(txtSearch);
            Controls.Add(lblTake);
            Controls.Add(lblSearch);
            Controls.Add(dtGridSuppliers);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Name = "FrmSuppliers";
            Text = "FrmSuppliers";
            Load += FrmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridSuppliers;
        private Label lblSearch;
        private Label lblTake;
        private TextBox txtSearch;
        private TextBox txtTake;
        private Button btnOrderByCompanyName;
        private Button btnTake;
        private Button btnDelete;
        private Label lblCompanyName;
        private Label label2;
        private Label label3;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private Button btnUpdate;
    }
}