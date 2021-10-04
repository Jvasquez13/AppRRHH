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


        public void OpVacaciones()
        {
            vacacionEmpleado = new VacacionesE();
            Console.WriteLine("Digite su cedula: ");
            vacacionEmpleado.CedulaVaciones();
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

        public void OpPermisos()
        {
            permisoEmpleado = new Permiso();
            Console.Write("Digite su cedula: ");
            permisoEmpleado.CedulaPermiso();
            Console.WriteLine("");
            Console.Write("Indique la fecha del permiso: ");
            permisoEmpleado.FechaPermiso();
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public void OpDesvinculacion()
        {
            desvinculacionEmpleado = new Desvinculacion();
            Console.WriteLine("Digite su cedula: ");
            desvinculacionEmpleado.CedulaDesvinculacion();
            Console.WriteLine("");
            Console.Write("Escriba la causa de las desvinculacion: ");
            desvinculacionEmpleado.CausaDesvinculacion();
            Console.WriteLine("Confirme su desicion presione 1 == si o 2 = no");
            desvinculacionEmpleado.ConfirmacionDesvinculacion();
            
            Console.WriteLine("");
            

        }


    }
}
