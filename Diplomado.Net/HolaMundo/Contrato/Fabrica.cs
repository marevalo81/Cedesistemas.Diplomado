using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HolaMundo.Ejemplo.Enumeraciones;

namespace HolaMundo.Contrato
{
    class Fabrica
    {
        public IContrato obtenerAdaptador(Operadores operador)
        {
            IContrato contrato = null;

            switch (operador)
            {
                case Operadores.tigo:
                    contrato = new ContratoTigo();
                    break;
                case Operadores.claro:
                    contrato = new ContratoClaro();
                    break;
                case Operadores.movistar:
                    contrato = new ContratoMovistar();
                    break;
               
            }

            return contrato;

        }
    }
}
