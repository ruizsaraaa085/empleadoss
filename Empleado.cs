using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public enum NivelRiesgo
    {
        NivelI = 1, // Riesgo mínimo
        NivelII = 2, // Riesgo bajo
        NivelIII = 3, // Riesgo medio
        NivelIV = 4, // Riesgo alto
        NivelV = 5  // Riesgo máximo
    }
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Arl { get; set; }
        public string Identificacion { get; set; }
        public double Salario { get; set; }
        public NivelRiesgo NivelRiesgoARL { get; set; } // Nuevo campo para el nivel de riesgo ARL
        public void IncrementarSalario(double Cuanto)
        {
            Salario = Salario + Cuanto;
        }
        public void DecrementarSalario(double Cuanto)
        {
            Salario = Salario - Cuanto;
        }

        public string CalcularNomina()
        {
            double saludEmpleado = Salario * 0.04;
            double pensionEmpleado = Salario * 0.04;
            double parafiscales = Salario * 0.09;
            double arlEmpleado = CalcularARL();
            double salarioBruto = Salario;

            // Aportes del empleador
            double saludEmpleador = Salario * 0.085;
            double pensionEmpleador = Salario * 0.12;

            // Aportes a fondo de solidaridad pensional
            double fondoSolidaridad = 0;
            string fondoSolidaridadTexto;

            double smmlv = 1423500;  // Salario mínimo

            if (Salario > 4 * smmlv && Salario <= 16 * smmlv)
            {
                fondoSolidaridad = 0.01 * (Salario - (4 * smmlv));  // 1% para salarios entre 4 y 16 SMMLV
                fondoSolidaridadTexto = fondoSolidaridad.ToString("N2");
            }
            else if (Salario > 16 * smmlv && Salario <= 20 * smmlv)
            {
                fondoSolidaridad = 0.02 * (Salario - (16 * smmlv));  // 2% para salarios entre 16 y 20 SMMLV
                fondoSolidaridadTexto = fondoSolidaridad.ToString("N2");
            }
            else if (Salario > 20 * smmlv)
            {
                fondoSolidaridad = 0.025 * (Salario - (20 * smmlv));  // 2.5% para salarios superiores a 20 SMMLV
                fondoSolidaridadTexto = fondoSolidaridad.ToString("N2");
            }
            else
            {
                fondoSolidaridadTexto = "No aplica";  // Para salarios menores a 4 SMMLV
            }



            // Mostrar resultados
            string resultado = $"Salario Básico: {Salario.ToString("N2")}\n";
            resultado += $"Aportes a Salud (Empleado): {saludEmpleado.ToString("N2")}\n";
            resultado += $"Aportes a Pensión (Empleado): {pensionEmpleado.ToString("N2")}\n";
            resultado += $"Aportes a Parafiscales: {parafiscales.ToString("N2")}\n";
            resultado += $"Aportes a ARL: {arlEmpleado}\n";
            resultado += $"Fondo de Solidaridad Pensional: {fondoSolidaridad.ToString("N2")}\n";
            resultado += $"Aportes de Salud (Empleador): {saludEmpleador.ToString("N2")}\n";
            resultado += $"Aportes de Pensión (Empleador): {pensionEmpleador.ToString("N2")}\n";

            return resultado;
        }
        private double CalcularARL()
        {
            double tasaARL = 0;

            switch (NivelRiesgoARL)
            {
                case NivelRiesgo.NivelI:
                    tasaARL = 0.00522; // 0.522% Riesgo mínimo
                    break;
                case NivelRiesgo.NivelII:
                    tasaARL = 0.01044; // 1.044% Riesgo bajo
                    break;
                case NivelRiesgo.NivelIII:
                    tasaARL = 0.02436; // 2.436% Riesgo medio
                    break;
                case NivelRiesgo.NivelIV:
                    tasaARL = 0.04350; // 4.350% Riesgo alto
                    break;
                case NivelRiesgo.NivelV:
                    tasaARL = 0.06960; // 6.960% Riesgo máximo
                    break;
            }

            return Salario * tasaARL; // Aporte ARL basado en la tasa
        }

        public string VerInfo()
        {
            string cadena = $"Nombre: {Nombre} \n Identificación: {Identificacion} \n Riesgo Arl: {Arl} \n Salario : {Salario}";

            return cadena;
        }
    }
}

