using EFDbFirst.Models;
using EFDbFirst.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst.Forms
{
    public partial class FrmAddSupplier : Form
    {
        public FrmAddSupplier()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService();

            Supplier supplier=new Supplier();
            supplier.CompanyName = txtName.Text;
            supplier.ContactName = txtDescription.Text;

            supplierService.AddSupplier(supplier);

            MessageBox.Show("Supplier added succesfuly.");
        }
        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {
            SupplierService supplier = new SupplierService();
            dataGridView1.DataSource = supplier.GetAllSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedSupplierId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                SupplierService supplier = new SupplierService();
                supplier.DeleteSupplier(selectedSupplierId);
                dataGridView1.DataSource = supplier.GetAllSuppliers();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
