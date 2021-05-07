using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        //metodo che gestisce l'handler
        string Handle(decimal request);
    }
}
