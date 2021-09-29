using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    public interface IEmpleado
    {
        string NombreEmpleado(string nombre);
        string Departamento(string departamento);
        string Cargo(string cargo);
        int HorasPrecio();
        int Precio();
        int Salario();
        long CuentaBancaria();
        DateTime Fecha();
       
    }
}
