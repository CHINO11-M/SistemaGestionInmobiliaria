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
    // CASCARONES DE CLASES (Para que Visual Studio no dé error)
    // El Integrante 2 se encargará de desarrollar estas clases por dentro
    // =================================================================
    public class Inmueble { }
    public class Cliente { }
    public class Contrato { }
}