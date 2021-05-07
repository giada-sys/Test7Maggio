using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada
{
    public class Spesa
    {
        public DateTime DataSpesa { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvazione { get; set; } = false;
        public string LivelloApprovazione { get; set; }
        public decimal Rimborso { get; set; }
    }
}
