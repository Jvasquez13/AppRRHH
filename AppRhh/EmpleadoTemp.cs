using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoTemp : IEmpleado
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
                int HorasTrabajadas = 8;
                

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
                Console.WriteLine(Salario);
                

                return Salario;
            }
        public long CuentaBancaria()
            {
                // Como este usuario es un empleado temporeo requiere cuenta bancaria y la solicitamos
                int CuentaBancaria = 0;
                Console.WriteLine("");
                Console.WriteLine("El metodo de pago es: ");
                Console.WriteLine("");
                Console.WriteLine("CHEQUE");
                Console.WriteLine("");

                return CuentaBancaria;
            }
            public  DateTime Fecha()
            {
                Console.WriteLine(""); 
                DateTime Fecha = DateTime.Now;
              
                return Fecha;

        }

        public string cedulaEmpleado(string cedula)
        {
            return cedula;
        }
        //Este usuario no necesita cuenta bancaria ya que es temporario y paga por cheque.
    }
}

