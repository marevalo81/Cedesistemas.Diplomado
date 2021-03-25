using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HolaMundo.Ejemplo.Enumeraciones;

namespace HolaMundo.Contrato
{
    class RecargasCelular : IContrato
    {
        public string Mensaje { get; set; }
        public Operadores currentOperator { get; set; } = Operadores.tigo;

        public bool cancelarRecarga(string telefono)
        {
            IContrato contrato = new Fabrica().obtenerAdaptador(currentOperator);
           
            bool response =  contrato.cancelarRecarga(telefono);
            Mensaje = contrato.Mensaje;
            return response;
        }

        public bool hacerRecarga(string telefono)
        {
            IContrato contrato = new Fabrica().obtenerAdaptador(currentOperator);
            bool response = contrato.hacerRecarga(telefono);
            Mensaje = contrato.Mensaje;
            return response;
        }
    }
}
