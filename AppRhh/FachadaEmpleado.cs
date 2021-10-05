using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class FachadaEmpleado
    {
        private VacacionesE vacacionEmpleado;
        private Permiso permisoEmpleado;
        private Desvinculacion desvinculacionEmpleado;
        private EmpleadoLista empleado;

        public void OpVacacionesEmpleado(List<EmpleadoLista> lista)
        {

            vacacionEmpleado = new VacacionesE();
            Console.WriteLine("Digite su cedula: ");
            string cedula = Console.ReadLine();
            empleado = GetEmpleado(cedula, lista);
            MostrarEmpleado(empleado);
            Console.WriteLine("");
            Console.Write("Escriba la fecha de inicio de sus vacaciones: ");
            vacacionEmpleado.FechaInicio();
            Console.WriteLine("");
            Console.Write("Escriba la fecha de termino de las vacaciones: ");
            vacacionEmpleado.FechaSalida();
            Console.WriteLine("");
            Console.Write("Los dias de vacaciones que posee son: ");
            vacacionEmpleado.VacacionesDias();
            Console.WriteLine("");
            Console.WriteLine("");


        }

        public void OpPermisosEmpleado(List<EmpleadoLista> lista)
        {
            permisoEmpleado = new Permiso();
            Console.Write("Digite su cedula: ");
            string cedula = Console.ReadLine();
            empleado = GetEmpleado(cedula, lista);
            MostrarEmpleado(empleado);
            Console.WriteLine("");
            Console.Write("Indique la fecha del permiso: ");
            permisoEmpleado.FechaPermiso();
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public void OpDesvinculacionEmpleado(List<EmpleadoLista> lista)
        {


            desvinculacionEmpleado = new Desvinculacion();
            Console.WriteLine("Digite su cedula: ");
            string cedula = Console.ReadLine();
            empleado = GetEmpleado(cedula, lista);
            MostrarEmpleado(empleado);
            Console.Write("Escriba la causa de las desvinculacion: ");
            desvinculacionEmpleado.CausaDesvinculacion();
            Console.WriteLine("");
            Console.WriteLine("Confirme su desicion presione 1 == Confirmar ");
            Console.WriteLine("");
            desvinculacionEmpleado.ConfirmacionDesvinculacion();
            EliminarEmpleado(empleado, lista);

            Console.WriteLine("");
            Console.WriteLine("");


        }

        public EmpleadoLista GetEmpleado(string cedula, List<EmpleadoLista> lista)
        {
            EmpleadoLista encontradoEmpleado = null;
            foreach (EmpleadoLista empleado in lista)
            {
                if (cedula == empleado.Cedula)
                {
                    encontradoEmpleado = empleado;
                    break;
                }
            }
            return encontradoEmpleado;
        }


        public void MostrarEmpleado(EmpleadoLista empleado)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*********************");
            Console.WriteLine("*Empleado Encontrado*");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("Nombre del empleado: " + empleado.Nombre); 
            Console.WriteLine("");
            Console.WriteLine("Numero de cedula: " + empleado.Cedula);
            Console.WriteLine("");
            Console.WriteLine("Departamento: " + empleado.Departamento);
            Console.WriteLine("");
            Console.WriteLine("Cargo: " + empleado.Cargo);
            Console.WriteLine("");
            Console.WriteLine("Fecha de creacion: " + empleado.FechaCreacion);
            Console.WriteLine("");
        }

        public void EliminarEmpleado(EmpleadoLista eliminar, List<EmpleadoLista> lista)
        {

            foreach (EmpleadoLista empleado in lista)
            {
                if (eliminar == empleado)
                {
                    lista.Remove(eliminar);
                    Console.WriteLine("");
                    Console.WriteLine("********************");
                    Console.WriteLine("*Empleado Eliminado*");
                    Console.WriteLine("********************");
                    Console.WriteLine("");
                    break;
                }
            }
        }
    }
}
