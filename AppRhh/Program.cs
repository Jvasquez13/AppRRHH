using System;
using System.IO;


namespace AppRhh
{
    class Cliente
    {

        static void Main(string[] args)
   
        {
            FachadaEmpleado fachada = new FachadaEmpleado();
            int seleccion;

            do
            {


                IEmpleado empleado;
                Console.WriteLine("*********************************************");
                Console.WriteLine("*Bienvenido a la app de RRHH de personal*");
                Console.WriteLine("*********************************************");
                Console.WriteLine("");
                Console.WriteLine("Elija una de las 3 opciones de registro de empleados");
                Console.WriteLine("1. Empleado tiempo completo");
                Console.WriteLine("2. Empleado medio tiempo");
                Console.WriteLine("3. Empleado temporaneo");
                Console.WriteLine("4. Vaciones Empleado");
                Console.WriteLine("5. Permiso Empleado");
                Console.WriteLine("6. Desvinculacion empleado");
                Console.WriteLine("");
                Console.WriteLine("Elija una opcion:");

                
                seleccion = int.Parse(Console.ReadLine());

                if (seleccion >= 1 && seleccion <= 3)
                {
                    empleado = Registro.RegistrarEmpleados(seleccion);
                    Console.WriteLine("");
                    Console.Write("Ingrese el nombre del empleado: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("----------------------------------------- ");
                    empleado.NombreEmpleado(nombre);
                    Console.Write("Nombre del empleado: ");
                    Console.WriteLine(empleado.NombreEmpleado(nombre));

                    //Solicitud Cedula Empleado
                    Console.WriteLine("");
                    Console.Write("Ingrese la cedula del empleado: ");
                    string cedula = Console.ReadLine();
                    Console.WriteLine("------------------------------------------");
                    empleado.cedulaEmpleado(cedula);
                    Console.Write("Cedula: ");
                    Console.WriteLine(empleado.cedulaEmpleado(cedula));

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

                    LogSingleton LogDeTexto = new LogSingleton(@"C:\Users\ESTUDIANTE\source\repos\AppRhh\AppRhh\bin\Debug\netcoreapp3.1");
                    LogDeTexto.Add("Nombre empleado: " + empleado.NombreEmpleado(nombre));
                    LogDeTexto.Add("Cedula: " + empleado.cedulaEmpleado(cedula));
                    LogDeTexto.Add("Departamento: " + empleado.Departamento(departamento));
                    LogDeTexto.Add("Cargo " + empleado.Cargo(cargo));
                    LogDeTexto.Add("Salario: " + empleado.Salario().ToString());
                    LogDeTexto.Add(empleado.Fecha().ToString());
                    LogDeTexto.Add("");
                    LogDeTexto.Add("----------------------------------------");
                }

                else if (seleccion == 4)
                {
                    fachada.OpVacaciones();
                }
                else if (seleccion == 5)
                {
                    fachada.OpPermisos();
                }
                else if (seleccion == 6)
                {
                    fachada.OpDesvinculacion();
                }


            } while (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6);


            
        }
    }
}
