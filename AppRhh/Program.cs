using System;
using System.IO;


namespace AppRhh
{
    class Cliente
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

            //Solicitud Empleado

            empleado = Registro.RegistrarEmpleados(seleccion);
            Console.WriteLine("");
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("----------------------------------------- ");
            empleado.NombreEmpleado(nombre);
            Console.Write("Nombre del empleado: ");
            Console.WriteLine(empleado.NombreEmpleado(nombre));

            //Solicitud Departamento

            Console.WriteLine("");
            Console.Write("Ingrese el Departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            empleado.Departamento(departamento);
            Console.Write("Departamento: ");
            Console.WriteLine(empleado.NombreEmpleado(departamento));

            //Solicitud Cargo
            Console.WriteLine("");
            Console.Write("Ingrese el Cargo: ");
            string cargo = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            empleado.Cargo(cargo);
            Console.Write("cargo: ");
            Console.WriteLine(empleado.Cargo(cargo));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Ingrese las horas trabajadas: ");
            empleado.HorasPrecio();
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ingrese el precio de las horas trabajadas: ");
            empleado.Precio();
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            empleado.CuentaBancaria();
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");

            Console.Write("Salario: ");
           


           
           



              empleado.Fecha();
              LogSingleton olog = new LogSingleton(@"C:\Users\ESTUDIANTE\source\repos\AppRhh\AppRhh\bin\Debug\netcoreapp3.1");
              olog.Add("Nombre empleado: " + empleado.NombreEmpleado(nombre));
              olog.Add("Departamento: " + empleado.Departamento(departamento));
              olog.Add("Cargo " + empleado.Cargo(cargo));
              olog.Add("Salario: " +empleado.Salario().ToString());
              olog.Add(empleado.Fecha().ToString());
             



        }
    }
}
