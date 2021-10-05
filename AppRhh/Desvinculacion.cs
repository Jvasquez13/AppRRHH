using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class Desvinculacion
    {
       
        private string causaDesvinculacion;

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
            else
            {
                Console.WriteLine("Error , elija presione el boton confirmar.");
                return false;
            }
    
            
        }

        
    }
}
