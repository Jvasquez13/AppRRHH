using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoTiempoC : IEmpleado
    {
        private int HorasTrabajadas = 8;
        private int PrecioHoras = 0;

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
            //Pedimos las horas trabajadas del empleado
            HorasTrabajadas = 8;
 
        

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
            return Salario;
        }
        public long CuentaBancaria()
        {
            // Como este usuario es un empleado de medio tiempo requiere cuenta bancaria y la solicitamos
            long CuentaBancaria = 0;
            Console.WriteLine("");
            Console.WriteLine("El metodo de pago es: ");
            Console.WriteLine("");
            Console.WriteLine("CUENTA BANCARIA");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su cuenta bancaria: ");

            CuentaBancaria = long.Parse(Console.ReadLine());

            return CuentaBancaria;
        }
        public DateTime Fecha()
        {
            Console.WriteLine("");
            DateTime Fecha = DateTime.Now;

            Console.WriteLine("");
            return Fecha;
        }

        public void Methof()
        {
            throw new System.NotImplementedException();
        }
    }

}

