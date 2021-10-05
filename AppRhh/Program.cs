using System;
using System.Collections.Generic;
using System.IO;


namespace AppRhh
{
    class Cliente
    {
        
        static void Main(string[] args)
        
        {
            List<EmpleadoLista> listaEmpleados = new List<EmpleadoLista>();
            FachadaEmpleado fachada = new FachadaEmpleado();
            int seleccion;

            do
            {

                #region CONSOLA
                IEmpleado empleado;
                Console.WriteLine("*********************************************");
                Console.WriteLine("*Bienvenido a la app de RRHH de personal*");
                Console.WriteLine("*********************************************");
                Console.WriteLine("");
                Console.WriteLine("Elija una de las 3 opciones de registro de empleados");
                Console.WriteLine("");
                Console.WriteLine("1. Empleado tiempo completo");
                Console.WriteLine("2. Empleado medio tiempo");
                Console.WriteLine("3. Empleado temporaneo");
                Console.WriteLine("4. Vaciones Empleado");
                Console.WriteLine("5. Permiso Empleado");
                Console.WriteLine("6. Desvinculacion empleado");
                Console.WriteLine("");
                Console.WriteLine("Elija una opcion:");

                
                seleccion = int.Parse(Console.ReadLine());
                #endregion


                if (seleccion >= 1 && seleccion <= 3)
                {
                    #region DATOS_EMPLEADO
                    Console.WriteLine("");
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

                    #endregion

                    #region LOG


                    EmpleadoLista lista = new EmpleadoLista();
                    lista.Nombre = nombre;
                    lista.Cedula = cedula;
                    lista.Departamento = departamento;
                    lista.Cargo = cargo;

                    listaEmpleados.Add(new EmpleadoLista
                    {
                        Nombre = lista.Nombre,
                        Cedula = lista.Cedula,
                        Departamento = lista.Departamento,
                        Cargo = lista.Cargo,
                        FechaCreacion = lista.FechaCreacion


                    }); ;

                    LogSingleton LogDeTexto = new LogSingleton(@"C:\Users\ESTUDIANTE\source\repos\AppRhh\AppRhh\bin\Debug\netcoreapp3.1");
                    LogDeTexto.Add("Nombre empleado: " + nombre);
                    LogDeTexto.Add("Cedula: " + cedula);
                    LogDeTexto.Add("Departamento: " + departamento);
                    LogDeTexto.Add("Cargo " + cargo);
                    LogDeTexto.Add("Salario: " + empleado.Salario().ToString());
                    Console.WriteLine(empleado.Fecha());
                    LogDeTexto.Add(empleado.Fecha().ToString());
                    LogDeTexto.Add("");
                    LogDeTexto.Add("----------------------------------------");

                    foreach (var dato in listaEmpleados)
                    {
                        Console.WriteLine(dato);
                      
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    #endregion
                }

                else if (seleccion == 4)
                {
                    Console.WriteLine("");
                    
                    fachada.OpVacacionesEmpleado(listaEmpleados);
                  
                }
                else if (seleccion == 5)
                {
                    Console.WriteLine("");
                   
                    fachada.OpPermisosEmpleado(listaEmpleados);             
                }
                else if (seleccion == 6)
                {
               
                    fachada.OpDesvinculacionEmpleado(listaEmpleados);
                    
                }


            } while (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6);
   

        }
    }
}
