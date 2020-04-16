using PTi1MenaxhimiDepos.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BL
{
    public static class SaleBLL
    {
        static SaleRepository SaleRepository = new SaleRepository();
        public static DataTable GetInvoicesToday()
        {
            return SaleRepository.GetInvoicesToday();
        }
    }
}
