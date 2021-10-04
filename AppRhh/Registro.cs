using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class Registro
    {
        public static IEmpleado RegistrarEmpleados (int TipoDeEmpleado)
        {
            //Cada una de las opciones sera reflejada como un tipo de empleado
            //La 1ra es el empleado a tiempo completo.

            if (TipoDeEmpleado == 1)
            {
                Console.WriteLine("Usted ha seleccionado la opcion Empleado a tiempo completo.");
                return new EmpleadoTiempoC();
            }
            else if (TipoDeEmpleado == 2)          //La 2da es el empleado a medio tiempo.
            {
                Console.WriteLine("Usted ha seleccionado la opcion Empleado a medio tiempo.");
                return new EmpleadoMedioT();
            }
            else if (TipoDeEmpleado == 3)       //La 3ra es el empleado a temporeo.
            {
                Console.WriteLine("Usted ha seleccionado la opcion Empleado temporero.");
                return new EmpleadoTemp();
            }

            else
            {
                return null;
            }
            
        }
    }
}
