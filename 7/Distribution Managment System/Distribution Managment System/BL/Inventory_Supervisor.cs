using Distribution_Managment_System.Data_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Inventory_Supervisor: User
    {
        public Inventory_Supervisor(string userID, string password, string name, string role, string email, string phoneNum) : base(userID, password, name, role, email, phoneNum)
        { 

        }
        public void AddProduct(Product rec)
        {
            Products_CRUD.addtoList(rec);
            Products_CRUD.StoreProduct(rec);
        }

        public void UpdateProduct(Product rec)
        {
            Products_CRUD.EditRecord(rec);
            Products_CRUD.RewriteProcuts();

        }

        public void AddSupplier(Supplier supplier)
        {
            Supplier_CRUD.AddObj(supplier);
            Supplier_CRUD.StoreSupplier(supplier);
        }

        public void UpdateSupplier(Supplier Old, Supplier New)
        {
            Supplier_CRUD.UpdateSupplier(Old, New);
            Supplier_CRUD.RewriteSuppliers();
        }

        public bool DeleteSupplier(string id)
        {
            bool result = Supplier_CRUD.DeleteSupplier(id);
            Supplier_CRUD.RewriteSuppliers();
            return result;
        }
    }
}
