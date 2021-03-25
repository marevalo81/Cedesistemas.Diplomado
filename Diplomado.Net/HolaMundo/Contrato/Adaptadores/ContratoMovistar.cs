using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Contrato
{
    // acepta recargas y cancelaciones en un rango de tiempo
    class ContratoMovistar : IContrato
    {
        public string Mensaje { get; set ; }

        public bool cancelarRecarga(string telefono)
        {
            Mensaje= "Cancelacion fuera del rango de tiempo permitido";
            return false;
        }

        public bool hacerRecarga(string telefono)
        {
            Mensaje = "No se pudo completar la recarga";
            return false;
        }
    }
}
