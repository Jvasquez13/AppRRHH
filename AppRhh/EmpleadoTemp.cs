using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoTemp : IEmpleado
    {
        public void Registrar()
        {
            String NombreEmpleado;
            String DepartamentoE;
            String CargoEmpleado;
            int HorasTrabajadas;
            int PrecioHoras;

            //Pedimos los datos de nuestro empleado
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del empleado: ");
            NombreEmpleado = Console.ReadLine();

            //Pedimos su departamento
            Console.WriteLine("");
            Console.WriteLine("Ingrese su departamento: ");

            DepartamentoE = Console.ReadLine();

            //Pedimos su cargo 
            Console.WriteLine("");
            Console.WriteLine("Ingrese su cargo: ");

            CargoEmpleado = Console.ReadLine();

            //Pedimos las horas trabajadas del empleado
            Console.WriteLine("");
            Console.WriteLine("Ingrese las horas trabajadas del empleado: ");

            HorasTrabajadas = int.Parse(Console.ReadLine());

            //Pedimos el precio de las horas
            Console.WriteLine("");
            Console.WriteLine("Ingrese cuanto cobra por hora: ");

            PrecioHoras = int.Parse(Console.ReadLine());

            // Como este usuario es un empleado temporero el pago sera por cheque
            Console.WriteLine("");
            Console.WriteLine("El metodo de pago es: ");
            Console.WriteLine("");
            Console.WriteLine("CHEQUE");
            Console.WriteLine("");
          
            //Capturamos el salario

            int Salario = HorasTrabajadas * PrecioHoras;

            Console.WriteLine("");
            Console.WriteLine(DateTime.Now);


            Console.WriteLine("");
            Console.WriteLine("EL EMPLEADO SE HA REGISTRADO CORRECTAMENTE!!!");

            //Este usuario no necesita cuenta bancaria ya que es temporario y paga por cheque.
        }
    }
}
