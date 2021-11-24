using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern
{
    class GerenteZonal : Aprobador
    {
        public override void ProcesarCompr(Compra c)
        {
            if (c.Importe < 1000)
            {
                Console.WriteLine("Operacion aprobada por el " + this.GetType().Name);
            }
            else
            {
                _siguiente.ProcesarCompr(c);
            }
        }
    }
}
