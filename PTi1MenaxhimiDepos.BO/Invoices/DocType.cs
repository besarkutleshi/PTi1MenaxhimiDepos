using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Invoices
{
    public class DocType : AuditionAtributtes
    {
        public DocType(int docTypeID, string code, string description)
        {
            DocTypeID = docTypeID;
            Code = code;
            Description = description;
        }

        public int DocTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
