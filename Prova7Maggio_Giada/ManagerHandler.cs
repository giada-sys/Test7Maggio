using Prova7Maggio_Giada.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada
{
    class ManagerHandler : AbstractHandler
    {
        public override string Handle(decimal request)
        {
            if (request <= 400)
                return $"Manager";
            else
                return base.Handle(request);
        }
    }
}
