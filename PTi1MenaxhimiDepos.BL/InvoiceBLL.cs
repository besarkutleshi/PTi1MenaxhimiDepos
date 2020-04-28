using PTi1MenaxhimiDepos.BO.Invoices;
using PTi1MenaxhimiDepos.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BL
{
    public static class InvoiceBLL
    {
        static InvertoryHeaderRepository HeaderRepository = new InvertoryHeaderRepository();
        static InvertoryBodyRepository BodyRepository = new InvertoryBodyRepository();

        #region Purchase Invoices
        public static bool InsertPurchaseInvoice(InvertoryHeader obj) => HeaderRepository.InsertInvoice(obj);
        public static bool DeletePurchaseInvoiceHeader(int id) => HeaderRepository.DeletePurchaseHeader(id);
        public static bool UpdatePurchaseInoviceHeader(int id, InvertoryHeader obj) => HeaderRepository.UpdatePurchaseHeader(id, obj);
        public static List<InvertoryHeader> GetPurchaseInvoicesHeader() => HeaderRepository.GetPurchaseInvertoryHeaders();
        public static InvertoryHeader GetPuchaseInvoicesHeaderByID(int id) => HeaderRepository.GetPurchaseInvertoryHeadersById(id);
        public static InvertoryHeader GetPurchaseInvoicesHeaderByDosNo(int docno) => HeaderRepository.GetPurchaseInvertoryHeadersByDocNo(docno);
        public static bool InsertBody(InvertoryBody obj) => BodyRepository.Add(obj);
        public static bool DeleteBody(int id) => BodyRepository.Delete(id);
        public static bool UpdateBody(int id, InvertoryBody obj) => BodyRepository.Update(id, obj);
        public static List<InvertoryBody> GetInvertoryBodiesByHeader(int headerid) => BodyRepository.ReadAllByHeaderID(headerid);
        public static InvertoryBody GetInvertoryBodyByID(int id) => BodyRepository.GetInvertoryBodyByID(id);
        public static DataTable ReturnDataTableBodies(List<InvertoryBody> invertoryBodies) => HeaderRepository.ReturnDT(invertoryBodies);
        #endregion
    }
}
