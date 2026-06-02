using System;
using System.Collections.Generic;

namespace SistemaGestionInmobiliaria
{
    // =================================================================
    // CLASE SINGLETON: Actúa como nuestra Base de Datos en Memoria
    // =================================================================
    public class SistemaCentral
    {
        // 1. La variable estática que guarda la ÚNICA copia del sistema
        private static SistemaCentral _instancia;

        // 2. Las listas globales que pide la rúbrica
        public List<Inmueble> ListaInmuebles { get; set; }
        public List<Cliente> ListaClientes { get; set; }
        public List<Contrato> ListaContratos { get; set; }

        // 3. Constructor PRIVADO (Evita que alguien haga "new SistemaCentral()")
        private SistemaCentral()
        {
            ListaInmuebles = new List<Inmueble>();
            ListaClientes = new List<Cliente>();
            ListaContratos = new List<Contrato>();
        }

        // 4. La Propiedad Pública para acceder al sistema desde cualquier formulario
        public static SistemaCentral Instancia
        {
            get
            {
                // Si el sistema no existe, lo crea. Si ya existe, devuelve el mismo.
                if (_instancia == null)
                {
                    _instancia = new SistemaCentral();
                }
                return _instancia;
            }
        }
    }

    // =================================================================
    // CLASES DE DATOS (MODELOS RELLENOS)
    // =================================================================

    public class Cliente
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Formato visual para cuando aparezca en las listas desplegables
        public override string ToString()
        {
            return $"{Nombre} - C.I: {Cedula}";
        }
    }

    public class Inmueble
    {
        public string Tipo { get; set; }
        public int Habitaciones { get; set; }
        public double Metraje { get; set; }
        public decimal PrecioUSD { get; set; }
        public bool Disponible { get; set; }

        // Formato visual para cuando aparezca en las listas desplegables
        public override string ToString()
        {
            return $"{Tipo} - {Metraje}m2 - ${PrecioUSD}";
        }
    }

    public class Contrato
    {
        public Cliente ClienteAsociado { get; set; }
        public Inmueble InmuebleAsociado { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}