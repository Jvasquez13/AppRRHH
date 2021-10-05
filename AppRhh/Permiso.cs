using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class Permiso
    {
        private DateTime fechaPermiso;
      

        public DateTime FechaPermiso()
        {
            fechaPermiso = DateTime.Parse(Console.ReadLine());

            return fechaPermiso;
        }
    }
}
