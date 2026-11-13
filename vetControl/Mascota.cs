using System;

namespace vetControl
{
    /// <summary>
    /// Clase que representa una mascota para el control de servicios veterinarios
    /// </summary>
    public class Mascota
    {
        // Campos privados
        private string nombre = "";
        private string especie = "";
        private int edad;
        private double peso;
        private char sexo;
        private string servicio = "";

        // Propiedades públicas con validación
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        /// <summary>
        /// Edad en años, solo acepta valores entre 0 y 30
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
        /// Peso en kilogramos, solo acepta valores mayores a 0
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

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        // Constructor
        public Mascota(string nombre, string especie, int edad, double peso, char sexo, string servicio)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Peso = peso;
            Sexo = sexo;
            Servicio = servicio;
        }

        /// <summary>
        /// Calcula la edad de la mascota en meses
        /// </summary>
        /// <returns>Edad multiplicada por 12</returns>
        public int CalcularEdadEnMeses()
        {
            return Edad * 12;
        }

        /// <summary>
        /// Determina la etapa de vida de la mascota
        /// Cachorro: 0 años, Adulto: 1 a 7 años, Senior: 8 años o más
        /// </summary>
        public string ObtenerEtapa()
        {
            if (Edad == 0)
                return "Cachorro";
            if (Edad < 8)
                return "Adulto";
            return "Senior";
        }

        /// <summary>
        /// Devuelve el nombre completo del sexo
        /// </summary>
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
        /// Devuelve el costo base según el servicio seleccionado
        /// </summary>
        public decimal CalcularCostoBase()
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
        /// Calcula el descuento: 10% para Senior, 0 para los demás
        /// </summary>
        public decimal CalcularDescuento()
        {
            if (ObtenerEtapa() == "Senior")
                return CalcularCostoBase() * 0.10m;
            return 0m;
        }

        /// <summary>
        /// Calcula el subtotal: costo base menos descuento
        /// </summary>
        public decimal CalcularSubtotal()
        {
            return CalcularCostoBase() - CalcularDescuento();
        }

        /// <summary>
        /// Calcula el impuesto del 13% sobre el subtotal
        /// </summary>
        public decimal CalcularImpuesto()
        {
            return CalcularSubtotal() * 0.13m;
        }

        /// <summary>
        /// Calcula el total a pagar con impuestos incluidos
        /// </summary>
        public decimal CalcularTotal()
        {
            return CalcularSubtotal() + CalcularImpuesto();
        }

        /// <summary>
        /// Arma el texto resumido con los datos de la mascota
        /// </summary>
        public string ObtenerResumen()
        {
            return $"{Nombre} ({ObtenerSexoCompleto()}) - {Especie} - {ObtenerEtapa()} - {Servicio} - ₡{CalcularTotal():N0}";
        }
    }
}
