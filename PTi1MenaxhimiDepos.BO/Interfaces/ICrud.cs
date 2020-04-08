using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.DAL
{
    public interface ICrud<T>
    {
        bool Add(T obj);
        bool Delete(int id);
        DataTable ReadAll();
        DataTable ReadById(int id);
        bool Update(int id, T obj);
    }
}
