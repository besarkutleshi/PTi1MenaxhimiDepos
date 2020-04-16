using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.DAL.Interface
{
    public interface IGetObject<T>
    {
        T Get(SqlDataReader sdr);
    }
}
