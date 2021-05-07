using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.Factory.Entita
{
    public class Altro : ICategoria
    {
        public decimal Sconto(decimal importo)
        {
            decimal sconto = importo *10/100;
            return sconto;
        }
    }
}
