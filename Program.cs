using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Aprobador comprador = new Comprador();
            Aprobador gerente = new GerenteZonal();
            Aprobador director = new Director();
            Aprobador directorGeneral = new DirectorGeneral();

            comprador.AgregarSiguiente(gerente);
            gerente.AgregarSiguiente(director);
            director.AgregarSiguiente(directorGeneral);

            Compra compra = new Compra();
            double importe = 1;
            while(importe != 0)
            {
                Console.WriteLine("Ingrese el importe a aprobar");
                importe = double.Parse(Console.ReadLine());
                compra.Importe = importe;
                //llama al primer eslabon de la cadena
                comprador.ProcesarCompr(compra);
            }

        }
    }
}
