using Prova7Maggio_Giada.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada
{
    public class CEOHandler : AbstractHandler
    {
        public override string Handle(decimal request)
        {
            if (request > 1000 && request <= 2500)
                return $"CEO";
            else
                return base.Handle(request);
        }
    }
}
