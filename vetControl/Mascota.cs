using System;

namespace vetControl
{
    /// <summary>
    /// Clase que representa una mascota del sistema VetControl
    /// </summary>
    public class Mascota
    {
        // Campos privados para las propiedades completas
        private int edad;
        private double peso;

        // Propiedades automáticas públicas
        public string Nombre { get; set; } = "";
        public string Especie { get; set; } = "";
        public char Sexo { get; set; }
        public string Servicio { get; set; } = "";

        /// <summary>
        /// Propiedad Edad con validación: 0 a 30 años
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0 && value <= 30)
                    edad = value;
            }
        }

        /// <summary>
        /// Propiedad Peso con validación: mayor a 0
        /// </summary>
        public double Peso
        {
            get { return peso; }
            set
            {
                if (value > 0)
                    peso = value;
            }
        }

        /// <summary>
        /// Calcula la edad en meses
        /// </summary>
        /// <returns>Años × 12</returns>
        public int CalcularEdadEnMeses()
        {
            return Edad * 12;
        }

        /// <summary>
        /// Determina la etapa de vida
        /// Cachorro: menor a 1 año | Adulto: 1 a 7 años | Senior: 8 años o más
        /// </summary>
        /// <returns>Nombre de la etapa</returns>
        public string ObtenerEtapa()
        {
            if (Edad < 1)
                return "Cachorro";
            else if (Edad <= 7)
                return "Adulto";
            else
                return "Senior";
        }

        /// <summary>
        /// Convierte el carácter del sexo a texto completo
        /// </summary>
        /// <returns>"Macho", "Hembra" o "Desconocido"</returns>
        public string ObtenerSexoCompleto()
        {
            switch (Sexo)
            {
                case 'M':
                case 'm':
                    return "Macho";
                case 'H':
                case 'h':
                    return "Hembra";
                default:
                    return "Desconocido";
            }
        }

        /// <summary>
        /// Devuelve el monto base según el servicio seleccionado
        /// </summary>
        /// <returns>Valor en colones</returns>
        public decimal ObtenerCostoBase()
        {
            switch (Servicio)
            {
                case "Consulta general": return 15000m;
                case "Vacunación": return 20000m;
                case "Desparasitación": return 18000m;
                case "Baño": return 12000m;
                default: return 0m;
            }
        }

        /// <summary>
        /// Calcula el descuento: 10% para Cachorros y Senior
        /// </summary>
        /// <returns>Monto del descuento</returns>
        public decimal CalcularDescuento()
        {
            string etapa = ObtenerEtapa();
            if (etapa == "Cachorro" || etapa == "Senior")
                return ObtenerCostoBase() * 0.10m;
            return 0m;
        }

        /// <summary>
        /// Calcula impuesto del 13% sobre el subtotal
        /// </summary>
        /// <returns>Monto del impuesto</returns>
        public decimal CalcularImpuesto()
        {
            decimal subtotal = ObtenerCostoBase() - CalcularDescuento();
            return subtotal * 0.13m;
        }

        /// <summary>
        /// Calcula el total a pagar con impuestos incluidos
        /// </summary>
        /// <returns>Monto final</returns>
        public decimal CalcularTotal()
        {
            decimal subtotal = ObtenerCostoBase() - CalcularDescuento();
            return subtotal + CalcularImpuesto();
        }

        /// <summary>
        /// Genera un resumen formateado con todos los datos de la mascota
        /// </summary>
        /// <returns>Cadena lista para mostrar</returns>
        public string ObtenerResumen()
        {
            return $"{Nombre} ({ObtenerSexoCompleto()}) - {Especie} - {ObtenerEtapa()} - {Servicio} - ₡{CalcularTotal():N0}";
        }
    }
}
