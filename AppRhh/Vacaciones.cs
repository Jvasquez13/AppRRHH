using System;
using System.Collections.Generic;
using System.Text;


namespace AppRhh
{
    class Vacaciones
    {
        private string cedula { get; set; }
        private DateTime fechaInicio;
        private DateTime fechaSalida;

        public string CedulaVaciones()
        {
            cedula = Console.ReadLine();

            return cedula;
        }
        public DateTime FechaInicio()
        {
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
      

            return fechaInicio;
        }
        public DateTime FechaSalida()
        {
            
            fechaSalida = Convert.ToDateTime(Console.ReadLine());
 

            return fechaSalida;
       
        }

        public int VacacionesDias()
        {
            
            int dias = (fechaSalida - fechaInicio).Days;

            return dias;
        }
       
    }

    
}
