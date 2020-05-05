using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.DAL;
using System.Data;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.BL
{
    public class CollaborationBLL
    {
        private readonly static SupplierRepository _supplierRep = new SupplierRepository();
        private readonly static ClientsRepository _clientsRep = new ClientsRepository();
        private readonly static EmployeeRepostiory _empRep = new EmployeeRepostiory();

        #region Supplier
        public static bool InsertSupplier(Supplier supplier)
        {
            return _supplierRep.Add(supplier);
        }

        public static bool DeleteSupplier(int id)
        {
            return _supplierRep.Delete(id);
        }

        public static List<Supplier> GetSuppliers()
        {
            return _supplierRep.ReadAll();
        }

        public static Supplier GetSupplier(int id)
        {
            return _supplierRep.ReadById(id);
        }

        public static Supplier GetSupplier(string name)
        {
            return _supplierRep.ReadByName(name);
        }

        public static bool UpdateSupplier(int id,Supplier supplier)
        {
            return _supplierRep.Update(id, supplier);
        }
        #endregion

        #region Client
        public static bool InsertClient(BO.Client obj) => _clientsRep.Add(obj);
        public static bool DeleteClient(int id) => _clientsRep.Delete(id);
        public static bool UpdateClient(int id, BO.Client obj) => _clientsRep.Update(id, obj);
        public static BO.Client GetClient(int id) => _clientsRep.ReadById(id);
        public static BO.Client GetClient(string name) => _clientsRep.ReadByName(name);
        public static List<BO.Client> GetClients() => _clientsRep.ReadAll();
        #endregion

        #region Employee
        public static bool InsertEmployee(BO.Employee obj)
        {
            return _empRep.Add(obj);
        }
        public static bool DeleteEmployee(int id)
        {
            return _empRep.Delete(id);
        }
        public static bool UpdateEmployee(int id,BO.Employee obj)
        {
            return _empRep.Update(id, obj);
        }
        public static List<BO.Employee> GetEmployees() => _empRep.ReadAll();

        public static BO.Employee GetEmployee(int id)
        {
            return _empRep.ReadById(id);
        }
        public static BO.Employee GetEmployee(string name) => _empRep.ReadByName(name);

        public static DataTable ReturnTableEmployees(List<Employee> employees)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(Employee).Name);
                System.Reflection.PropertyInfo[] Props = typeof(Employee).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                foreach (System.Reflection.PropertyInfo item in Props)
                {
                    if (item.Name == "Username")
                    {
                        continue;
                    }
                    if(item.Name == "Address")
                    {
                        dataTable.Columns.Add("Street");
                        dataTable.Columns.Add("City");
                        dataTable.Columns.Add("Country");
                        dataTable.Columns.Add("Postal Code");
                        continue;
                    }
                    dataTable.Columns.Add(item.Name);
                }
                foreach (var item in employees)
                {
                    if (item == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        object[] values = new object[10];
                        values[0] = item.ID;
                        values[1] = item.Name;
                        values[2] = item.Surname;
                        values[3] = item.Email;
                        values[4] = item.Phone;
                        values[5] = item.Address.Street;
                        values[6] = item.Address.City;
                        values[7] = item.Address.Country;
                        values[8] = item.Address.PostalCode;
                        values[9] = item.Fullname;
                        dataTable.Rows.Add(values);
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

    }
}
