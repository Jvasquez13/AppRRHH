using System;
using System.Collections.Generic;
using System.Text;

namespace AppRhh
{
    class EmpleadoLista
    {
        private string nombre;
        private string cedula;
        private string departamento;
        private string cargo;
        private int salario;
        private DateTime fechaCreacion;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = DateTime.Now; }
        }

    }
}
