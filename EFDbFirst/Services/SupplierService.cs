using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst.Services
{
    public class SupplierService
    {
        public Supplier AddSupplier(Supplier supplier) 
        {
            NorthwndContext db = new NorthwndContext();

            db.Suppliers.Add(supplier);
            db.SaveChanges();
            
            return supplier;
        }
        public List<Supplier> GetAllSuppliers() 
        {
            NorthwndContext db = new NorthwndContext();
            List<Supplier> suppliers = db.Suppliers.OrderBy(q => q.CompanyName).ToList();
            return suppliers;
        }

        public Supplier GetSupplierById(int id)
        {
            NorthwndContext db = new NorthwndContext();
            Supplier suppliers = db.Suppliers.FirstOrDefault(q => q.SupplierId == id);
            return suppliers;
        }

        public void DeleteSupplier(int selectedSupplierId)
        {
            NorthwndContext db=new NorthwndContext();
            Supplier supplier = db.Suppliers.Find(selectedSupplierId);
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }
    }
}
