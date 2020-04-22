using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public interface IBase
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        Address Address { get; set; }
    }
}
