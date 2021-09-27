using System;
using System.IO;


namespace AppRhh
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmpleado empleado;

            Console.WriteLine("*********************************************");
            Console.WriteLine("*Bienvenido a la app de Registro de personal*");
            Console.WriteLine("*********************************************");

            Console.WriteLine("");
            Console.WriteLine("Elija una de las 3 opciones de registro de empleados");
            Console.WriteLine("1. Empleado tiempo completo");
            Console.WriteLine("2. Empleado medio tiempo");
            Console.WriteLine("3. Empleado temporaneo");

            int seleccion = int.Parse(Console.ReadLine());

            empleado = Registro.RegistrarEmpleados(seleccion);

            empleado.Registrar();
            Console.ReadLine();
         
        
        }
    }
}
