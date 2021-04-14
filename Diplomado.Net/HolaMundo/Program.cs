
using HolaMundo.AsyncProgramming;
using HolaMundo.Contrato;
using HolaMundo.EventosDelegados;
using HolaMundo.Tupla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HolaMundo.Ejemplo.Enumeraciones;

namespace HolaMundo
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Clases y Tipos
            //RecargasCelular recargasCelular = new RecargasCelular();
            //recargasCelular.currentOperator = Operadores.claro;
            //bool response = recargasCelular.hacerRecarga("2996903");
            //if (response)
            //{
            //    Console.WriteLine("Fue exitoso");
            //    Console.WriteLine(recargasCelular.Mensaje);
            //}
            //else
            //    Console.WriteLine("Fue fallido");
            //Console.WriteLine(response ? recargasCelular.Mensaje : "fue fallido");
            //string mensaje = "Fin del ejemplo";
            //Console.WriteLine(mensaje ?? "esta vacio");
            #endregion
            #region delegados
            //Del handler = Delegados.DelegateMethod;

            ////handler("Clase de .NET CORE");
            ////Delegados.MethodWithCallback(2, 5, handler);

            //Del handler2 = Delegados.DelegateMethod2;
            //Del handler3 = Delegados.DelegateMethod3;
            //Del allDelegates = handler + handler2;
            //allDelegates += handler3;

            //allDelegates("prueba");
            #endregion
            #region lambdas
            //Action<string> greet = name => Console.WriteLine($"Hello {name}!");

            //greet("World");

            //Func<string> greet2 = () =>
            // {
            //     string greeting = $"Hello mundo!";
            //     return greeting;
            // };

            //Console.WriteLine(greet2());

            //(double, int) t1 = (4.5, 3);
            #endregion
            #region tuplas y Linq
            //Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            ////(int minimo, int maximo) res = new tuplas().FindMinMax(5, 3);
            ////Console.WriteLine($"minimo={res.minimo.ToString()}");
            ////Console.WriteLine($"maximo={res.maximo.ToString()}");

            //(List<TransactionCost>, int) list = new tuplas().CostosTransaccion();
            //foreach (var item in list.Item1)
            //{
            //    if (item.category == "T")
            //        Console.WriteLine($"El valor de la tasa entre {item.minValue} y {item.maxValue} es {item.valor}");
            //    else Console.WriteLine($"El valor de la comision entre {item.minValue} y {item.maxValue} es {item.valor}");
            //}

            //var query = (from p in list.Item1
            //             where p.category == "T"
            //             select p).FirstOrDefault();

            //var query2 = (from p in list.Item1
            //              select p.category).ToArray();

            //var query3 = (from p in list.Item1
            //              select new categoryValor() { category = p.category, valor = p.valor }).ToList();

            //var query4 = list.Item1.Where(x => x.category == "T" && x.maxValue<10000).FirstOrDefault();



            //Console.WriteLine($"El monto de la transaccion debe ser multiplo de {list.Item2.ToString()}");
            #endregion
            Console.WriteLine("Comienzo a preparar el desayuno");
            Asincronos desayuno = new Asincronos();
            
            Task var = desayuno.PrepararDesayuno();
            Console.WriteLine("Termino el desayuno");
            
            Console.ReadLine();
        }


    }
}
