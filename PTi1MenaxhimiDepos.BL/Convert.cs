using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BL
{
    public class Convert
    { 
        public static DataTable ConvertToDataTable<T>(List<T> rows)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (System.Reflection.PropertyInfo item in Props)
            {
                if(item.Name == "UnitID" || item.Name == "CategoryId" || item.Name == "TypeID" || item.Name == "SupplierID")
                {
                    continue;
                }
                dataTable.Columns.Add(item.Name);
            }
            foreach (T item in rows)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
