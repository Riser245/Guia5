using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_5_FC250417
{
    public class empleado
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public decimal SalarioDiario { get; set; }

        public empleado() { }

        public empleado(string nombre, string identificacion, decimal salarioDiario)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            SalarioDiario = salarioDiario;
        }

        public decimal CalcularSalario(int diasTrabajados)
        {
            if (diasTrabajados >= 0 && SalarioDiario >= 0)
            {
                return diasTrabajados * SalarioDiario;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{Nombre} ({Identificacion})";
        }
    }
}

