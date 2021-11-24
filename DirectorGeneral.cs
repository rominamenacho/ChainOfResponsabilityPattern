using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern
{
   public class DirectorGeneral : Aprobador
    {
        public override void ProcesarCompr(Compra c)
        {
            Console.WriteLine("Operacion aprobada por el " + this.GetType().Name);

        }
    }
}
