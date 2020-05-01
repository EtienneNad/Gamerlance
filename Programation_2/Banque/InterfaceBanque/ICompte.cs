using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque;

namespace InterfaceBanque
{
    public interface ICompte 
    {
        uint Numero { get; }
        long Solde { get; }
        long MargeCredit { get; }

    }
}
