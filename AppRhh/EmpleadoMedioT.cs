using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoMedioT : IEmpleado
    {
         private int HorasTrabajadas = 4;
         private int PrecioHoras= 8;
        public string NombreEmpleado(string nombre)
        {
            //Pedimos los datos de nuestro empleado


            return nombre;
        }
        public string Departamento(string departamento)
        {          
            //Pedimos su departamento

            return departamento;
        }
        public string Cargo(string cargo)
        {
            //Pedimos su cargo 

            return cargo;
        }
        public int HorasPrecio()
        {
            HorasTrabajadas = int.Parse(Console.ReadLine());
            return HorasTrabajadas;
        }
        public int Precio()
        {
            //Pedimos el precio de las horas
            PrecioHoras = int.Parse(Console.ReadLine());

            return PrecioHoras;
        }

        public int Salario()
        {
            int Salario = HorasTrabajadas * PrecioHoras * (23);
            Console.Write(Salario);
            Salario.ToString();

            return Salario;
        }
        public long CuentaBancaria()
        {
            // Como este usuario es un empleado de medio tiempo requiere cuenta bancaria y la solicitamos
            int CuentaBancaria = 0;
            Console.WriteLine("");
            Console.WriteLine("El metodo de pago es: ");
            Console.WriteLine("");
            Console.WriteLine("CUENTA BANCARIA");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su cuenta bancaria: ");

            CuentaBancaria = int.Parse(Console.ReadLine());

            return CuentaBancaria;
        }
        public DateTime Fecha()
        {
            Console.WriteLine("");
            DateTime Fecha = DateTime.Now;

            

            return Fecha;
        }
   
    }
}

