using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.DAL;
namespace PTi1MenaxhimiDepos.BL
{
    public class Collaboration
    {
        static SupplierRepository supplierRep = new SupplierRepository();
        static ClientsRepository clientsRep = new ClientsRepository();

        #region Supplier
        public static bool InsertSupplier(Supplier supplier)
        {
            return supplierRep.Add(supplier);
        }

        public static bool DeleteSupplier(int id)
        {
            return supplierRep.Delete(id);
        }

        public static List<Supplier> GetSuppliers()
        {
            return supplierRep.ReadAll();
        }

        public static Supplier GetSupplier(int id)
        {
            return supplierRep.ReadById(id);
        }

        public static Supplier GetSupplier(string name)
        {
            return supplierRep.ReadByName(name);
        }

        public static bool UpdateSupplier(int id,Supplier supplier)
        {
            return supplierRep.Update(id, supplier);
        }
        #endregion

        #region Client


        #endregion

    }
}
