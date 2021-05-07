using Prova7Maggio_Giada.Factory.Entita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.Factory
{
    public class CategoriaFactory
    {
        public static ICategoria FactoryCategoria(string cat)
        {
            if (cat.Equals("Viaggio"))
                return new Viaggio();
            else if (cat.Equals("Alloggio"))
                return new Alloggio();
            else if (cat.Equals("Vitto"))
                return new Vitto();
            else if (cat.Equals("Altro"))
                return new Altro();
            return null;
        }
    }
}
