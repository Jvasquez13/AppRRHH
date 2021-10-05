using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class VacacionesE
    {
        
        private DateTime fechaInicio;
        private DateTime fechaSalida;
     
   
        public DateTime FechaInicio()
        {
            fechaInicio = DateTime.Parse(Console.ReadLine());

            return fechaInicio;
        }
        public DateTime FechaSalida()
        {

            fechaSalida = DateTime.Parse(Console.ReadLine());

            return fechaSalida;

        }
        public int VacacionesDias()
        {
            TimeSpan restaFechas = fechaSalida - fechaInicio;
            int diasVacaciones = restaFechas.Days;
            Console.WriteLine(diasVacaciones);

            return diasVacaciones;
            
        }
    }
}


