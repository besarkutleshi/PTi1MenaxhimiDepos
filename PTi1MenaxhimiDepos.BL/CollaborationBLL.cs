using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.DAL;
namespace PTi1MenaxhimiDepos.BL
{
    public class CollaborationBLL
    {
        static SupplierRepository supplierRep = new SupplierRepository();
        static ClientsRepository clientsRep = new ClientsRepository();
        static EmployeeRepostiory empRep = new EmployeeRepostiory();

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
        public static bool InsertClient(BO.Client obj) => clientsRep.Add(obj);
        public static bool DeleteClient(int id) => clientsRep.Delete(id);
        public static bool UpdateClient(int id, BO.Client obj) => clientsRep.Update(id, obj);
        public static BO.Client GetClient(int id) => clientsRep.ReadById(id);
        public static BO.Client GetClient(string name) => clientsRep.ReadByName(name);
        public static List<BO.Client> GetClients() => clientsRep.ReadAll();
        #endregion

        #region Employee
        public static bool InsertEmployee(BO.Employee obj)
        {
            return empRep.Add(obj);
        }
        public static bool DeleteEmployee(int id)
        {
            return empRep.Delete(id);
        }
        public static bool UpdateEmployee(int id,BO.Employee obj)
        {
            return empRep.Update(id, obj);
        }
        public static List<BO.Employee> GetEmployees() => empRep.ReadAll();

        public static BO.Employee GetEmployee(int id)
        {
            return empRep.ReadById(id);
        }
        public static BO.Employee GetEmployee(string name) => empRep.ReadByName(name);

        #endregion

    }
}
