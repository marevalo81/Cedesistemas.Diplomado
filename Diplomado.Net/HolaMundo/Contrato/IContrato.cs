using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Contrato
{
    public interface IContrato
    {
        string Mensaje { get; set; }
        bool hacerRecarga(string telefono);
        bool cancelarRecarga(string telefono);
    }
}
