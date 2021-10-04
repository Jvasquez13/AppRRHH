using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class Desvinculacion
    {
        private string cedula { get; set; }
        private string causaDesvinculacion;

        public string CedulaDesvinculacion()
        {
            cedula = Console.ReadLine();

            return cedula;
        }

        public string CausaDesvinculacion()
        {
            causaDesvinculacion = Console.ReadLine();

            return causaDesvinculacion;
        }

        public bool ConfirmacionDesvinculacion()
        {
            bool confirmacionDesvinculacion;

            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                confirmacionDesvinculacion = true;
                Console.WriteLine("Empleado desvinculado: " +confirmacionDesvinculacion);
                return confirmacionDesvinculacion;
            }
            else if (seleccion == 2)
            {

                confirmacionDesvinculacion = false;
                Console.WriteLine("Empleado devinculado: " + confirmacionDesvinculacion);
                return confirmacionDesvinculacion;
            }
            else
            {
                Console.WriteLine("Error , elija una de las 2 opciones.");
                return false;
            }
    
            
        }

        
    }
}
