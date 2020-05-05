using PTi1MenaxhimiDepos.BO.Invoices;
using PTi1MenaxhimiDepos.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.BL
{
    public static class InvoiceBLL
    {
        private readonly static InvertoryHeaderRepository _headerRepository = new InvertoryHeaderRepository();
        private readonly static InvertoryBodyRepository _bodyRepository = new InvertoryBodyRepository();
        private readonly static DocTypeRepository _docTypeRepository = new DocTypeRepository();

        #region Purchase Invoices
        public static bool InsertPurchaseInvoice(InvertoryHeader obj) => _headerRepository.InsertInvoice(obj);
        public static bool DeletePurchaseInvoiceHeader(int id) => _headerRepository.DeletePurchaseHeader(id);
        public static bool UpdatePurchaseInoviceHeader(int id, InvertoryHeader obj) => _headerRepository.UpdatePurchaseHeader(id, obj);
        public static List<InvertoryHeader> GetPurchaseInvoicesHeader() => _headerRepository.GetPurchaseInvertoryHeaders();
        public static InvertoryHeader GetPuchaseInvoicesHeaderByID(int id) => _headerRepository.GetPurchaseInvertoryHeadersById(id);
        public static InvertoryBody GetInvertoryBodyByItem(string item, int headerid) => _bodyRepository.GetInvertoryBodyByItem(item, headerid);
        public static InvertoryHeader GetPurchaseInvoicesHeaderByDosNo(string docno) => _headerRepository.GetPurchaseInvertoryHeadersByDocNo(docno);
        public static bool InsertBody(InvertoryBody obj) => _bodyRepository.Add(obj);
        public static bool DeleteBody(int id) => _bodyRepository.Delete(id);
        public static bool UpdateBody(int id, InvertoryBody obj) => _bodyRepository.Update(id, obj);
        public static List<InvertoryBody> GetInvertoryBodiesByHeader(int headerid) => _bodyRepository.ReadAllByHeaderID(headerid);
        public static InvertoryBody GetInvertoryBodyByID(int id) => _bodyRepository.GetInvertoryBodyByID(id);
        public static DataTable ReturnDataTableBodies(List<InvertoryBody> invertoryBodies) => _headerRepository.ReturnDT(invertoryBodies);
        public static int MaxID() => _headerRepository.GetMaxID();
        public static int MaxDocNo() => _headerRepository.GetMaxDocNo();
        public static void RefreshGrid(List<InvertoryBody> invertoryBodies,RadGridView radGridView)
        {
            radGridView.DataSource = null;
            radGridView.DataSource = invertoryBodies;
        }
        #endregion


        #region DocType

        public static bool InsertDocType(DocType obj) => _docTypeRepository.Add(obj);
        public static bool DeleteDocType(int id) => _docTypeRepository.Delete(id);
        public static bool UpdateDocType(int id, DocType obj) => _docTypeRepository.Update(id, obj);
        public static List<DocType> GetDocTypes() => _docTypeRepository.ReadAll();
        public static DocType GetDocType(int id) => _docTypeRepository.ReadById(id);
        public static DocType GetDocType(string name) => _docTypeRepository.ReadByName(name); 
        #endregion
    }
}
