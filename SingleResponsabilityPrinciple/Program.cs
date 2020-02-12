using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Cristian", "Programador", 24, 3000000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
            Console.ReadLine();
        }
    }
}
