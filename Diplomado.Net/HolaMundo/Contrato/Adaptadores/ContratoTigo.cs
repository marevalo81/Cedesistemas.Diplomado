using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Contrato
{
    // hace recargas y acepta cancelaciones
    class ContratoTigo : IContrato
    {
        public string Nombre { get; set; }
        public string Mensaje { get; set; }

        public bool cancelarRecarga(string telefono)
        {
            Mensaje = "Cancelacion exitosa";
            return true;
        }

        public bool hacerRecarga(string telefono)
        {
            Mensaje = "Recarga exitosa";
            return true;
        }

        public string obtenerNombre()
        {
            return Nombre;
        }

        internal string obtenerFullName(string apellido)
        {
            return nombreFormateado(apellido);
        }

        string nombreFormateado(string apellido)
        {
            return $"{Nombre} {apellido}";
        }
    }
}
