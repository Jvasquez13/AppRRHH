using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class Permiso
    {
        private string cedula { get; set; }
        private DateTime fechaPermiso;
        public string CedulaPermiso()
        {
            cedula = Console.ReadLine();

            return cedula;
        }

        public DateTime FechaPermiso()
        {
            fechaPermiso = DateTime.Parse(Console.ReadLine());

            return fechaPermiso;
        }
    }
}
