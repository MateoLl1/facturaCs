using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Cliente
    {
        private int cedula;
        private String nombre;
        private String apellido;
        private string fechaDeNacimiento;
        private int dia, mes, anio;
        private int edad;
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaDeNacimiento { get => FechaDeNacimiento1; set => FechaDeNacimiento1 = value; }
        
        public string FechaDeNacimiento1 { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
