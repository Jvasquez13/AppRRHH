using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class ErrorSeleccion : IEmpleado
    {
        public void Registrar()
        {
            Console.WriteLine("ERROR, Elija una de las 3 opciones en pantalla!");
        }
    }
 
    
}
