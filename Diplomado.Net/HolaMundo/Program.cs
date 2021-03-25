
using HolaMundo.Contrato;
using System;
using static HolaMundo.Ejemplo.Enumeraciones;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            RecargasCelular recargasCelular = new RecargasCelular();
            recargasCelular.currentOperator = Operadores.claro;
            bool response = recargasCelular.hacerRecarga("2996903");
            //if (response)
            //{
            //    Console.WriteLine("Fue exitoso");
            //    Console.WriteLine(recargasCelular.Mensaje);
            //}
            //else
            //    Console.WriteLine("Fue fallido");
            Console.WriteLine(response ? recargasCelular.Mensaje : "fue fallido");
            string mensaje = "Fin del ejemplo";
            Console.WriteLine(mensaje ?? "esta vacio");
            Console.ReadLine();


        }
    }
}
