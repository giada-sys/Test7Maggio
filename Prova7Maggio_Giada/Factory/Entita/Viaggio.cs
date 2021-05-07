using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.Factory.Entita
{
    class Viaggio : ICategoria
    {
        public decimal Sconto(decimal importo)
        {
            decimal sconto = importo + 50;
            return sconto;
        }
    }
}
