using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.BO.Account;
using PTi1MenaxhimiDepos.DAL;
namespace PTi1MenaxhimiDepos.BL
{
    public class AdministrationBLL
    {
        static AccountRepository AccountRepository = new AccountRepository();
        static RoleRepository RoleRepository = new RoleRepository();

        #region User
        public static BO.Account.User Login(string username,string password)
        {
            return AccountRepository.Login(username, password);
        }
        public static bool InsertUser(BO.Account.User user)
        {
            return AccountRepository.Add(user);
        }
        public static bool DeleteUser(int id)
        {
            return AccountRepository.Delete(id);
        }
        public static bool UpdateUser(int id,BO.Account.User user)
        {
            return AccountRepository.Update(id, user);
        }
        public static List<BO.Account.User> GetUsers()
        {
            return AccountRepository.ReadAll();
        }
        public static BO.Account.User GetUser(int id)
        {
            return AccountRepository.ReadById(id);
        }
        public static BO.Account.User GetUser(string username)
        {
            return AccountRepository.ReadByUsername(username);
        }

        public static DataTable ReturnUsers(List<BO.Account.User> users)
        {
            DataTable dataTable = new DataTable(typeof(BO.Account.User).Name);
            System.Reflection.PropertyInfo[] Props = typeof(BO.Account.User).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (System.Reflection.PropertyInfo item in Props)
            {
                if (item.Name == "Username" || item.Name == "EmployeeID" || item.Name == "RoleID")
                {
                    continue;
                }
                dataTable.Columns.Add(item.Name);
            }
            foreach (var item in users)
            {
                if (item == null)
                {
                    throw new Exception();
                }
                else
                {
                    object[] values = new object[6];
                    values[0] = item.ID;
                    values[1] = item.UserName;
                    values[2] = item.Password;
                    values[3] = item.Description;
                    values[4] = item.Role.Name;
                    values[5] = item.Employee.Name;
                    dataTable.Rows.Add(values);
                }
            }
            return dataTable;
        }

        #endregion

        #region Role
        public static bool InsertRole(BO.Role obj)
        {
            return RoleRepository.Add(obj);
        }

        public static bool DeleteRole(int id)
        {
            return RoleRepository.Delete(id);
        }
        public static bool UpdateRole(int id,BO.Role obj)
        {
            return RoleRepository.Update(id, obj);
        }
        public static List<BO.Role> GetRoles()
        {
            return RoleRepository.ReadAll();
        }
        public static BO.Role GetRole(int id)
        {
            return RoleRepository.ReadById(id);
        }
        public static BO.Role GetRole(string name)
        {
            return RoleRepository.ReadByName(name);
        }
        #endregion

    }
}
