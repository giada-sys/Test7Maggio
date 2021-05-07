using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.Factory.Entita
{
    public class Alloggio : ICategoria
    {
        public decimal Sconto(decimal importo)
        {
            return importo;
        }
    }
}
