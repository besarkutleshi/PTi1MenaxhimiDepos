using PTi1MenaxhimiDepos.BO.EntiresExits;
using PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports;
using PTi1MenaxhimiDepos.BO.EntiresExits.ItemReports;
using PTi1MenaxhimiDepos.BO.EntiresExits.SupplierReports;
using PTi1MenaxhimiDepos.DAL.EntriesExits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BL
{
    public static class EntriesExitsBL
    {
        static MonthProfitsRepository _monthprofits = new MonthProfitsRepository();
        static ClientReportRepository _clientReportRepository = new ClientReportRepository();
        static ItemReportRepository _itemReportRepository = new ItemReportRepository();
        static SupplierReportRepository _supplierReportRepository = new SupplierReportRepository();
        public static IEnumerable<MonthProfits> GetMonthProfits() => _monthprofits.GetMonthProfits();
        public static IEnumerable<WeekProfits> GetWeekProfits() => _monthprofits.GetWeekProfits();
        public static IEnumerable<MonthProfits> GetMonthExits() => _monthprofits.GetMonthExits();
        public static IEnumerable<WeekProfits> GetWeekExits() => _monthprofits.GetWeekExits();
        public static List<ClientReport> GetClientReports() => _clientReportRepository.GetClientReports();
        public static List<ClientInvoices> GetClientInvoices(int id) => _clientReportRepository.GetClientInvoices(id);
        public static List<ItemReport> GetItemReports() => _itemReportRepository.GetItemReports();
        public static List<SupplierReport> GetSupplierReports() => _supplierReportRepository.GetSupplierReports();
        public static List<ItemReport> GetItemExitReports() => _itemReportRepository.GetExitItemReports();
    }
}
