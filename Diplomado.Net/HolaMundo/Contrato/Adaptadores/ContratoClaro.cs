using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Contrato
{
    // No permite cancelar, permite consultar recarga
    class ContratoClaro : IContrato
    {
        public string Mensaje { get; set; }

        public bool cancelarRecarga(string telefono)
        {
            throw new NotImplementedException();
        }

        public bool hacerRecarga(string telefono)
        {
            this.Mensaje = $"La recarga al telefono {telefono} ha sido exitosa. Su numero de comprobante es 00000";
            return true;
        }
    }
}
