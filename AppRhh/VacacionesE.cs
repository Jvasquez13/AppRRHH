using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class VacacionesE
    {
        private string cedula { get; set; }
        private DateTime fechaInicio;
        private DateTime fechaSalida;
        private TimeSpan restaFechas;
        private int diasVacaciones;

        public string CedulaVaciones()
        {
            cedula = Console.ReadLine();

            return cedula;
        }
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
            restaFechas = fechaSalida - fechaInicio;
            diasVacaciones = restaFechas.Days;
            Console.WriteLine(diasVacaciones);

            return diasVacaciones;
            
        }
    }
}


