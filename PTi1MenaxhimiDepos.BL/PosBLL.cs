using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BL
{
    public static class PosBLL
    {
        static PointofSalesRepository posRepository = new PointofSalesRepository();
        public static bool InsertPos(PointofSale obj)
        {
            return posRepository.Add(obj);
        }

        public static bool DeletePos(int id)
        {
            return posRepository.Delete(id);
        }

        public static bool UpdatePos(int id,PointofSale obj)
        {
            return posRepository.Update(id, obj);
        }

        public static List<PointofSale> GetPointofSales()
        {
            return posRepository.ReadAll();
        }

        public static PointofSale GetPointofSale(int id)
        {
            return posRepository.ReadById(id);
        }
        public static PointofSale GetPointofSale(string name)
        {
            return posRepository.ReadByName(name);
        }
    }
}
