using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoMedioT : IEmpleado
    {
        public void Registrar()
        {
            String NombreEmpleado;
            String DepartamentoE;
            String CargoEmpleado;
            int CuentaBancaria;
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

            // Como este usuario es un empleado de medio tiempo requiere cuenta bancaria y la solicitamos
            Console.WriteLine("");
            Console.WriteLine("El metodo de pago es: ");
            Console.WriteLine("");
            Console.WriteLine("CUENTA BANCARIA");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su cuenta bancaria: ");

            CuentaBancaria = int.Parse(Console.ReadLine());


            //Capturamos el salario

            int Salario = HorasTrabajadas * PrecioHoras;

            Console.WriteLine("");
            Console.WriteLine(DateTime.Now);


            Console.WriteLine("");
            Console.WriteLine("EL EMPLEADO SE HA REGISTRADO CORRECTAMENTE!!!");
        }
    }
}

