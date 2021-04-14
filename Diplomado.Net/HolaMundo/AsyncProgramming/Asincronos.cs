using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.AsyncProgramming
{
    internal class Asincronos
    {
        internal void prepararCafe()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Preparo el cafe");
        }
        internal void prepararHuevo()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Preparo el huevo");
        }

        internal void asarArepa()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("asar la arepa");
        }

        internal async Task<int> prepararCafeAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("Preparo el cafe");
            return 1;
        }
        internal async Task<int> prepararHuevoAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Preparo el huevo");
            return 2;
        }

        internal async Task<int> asarArepaAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("asar la arepa");
            return 3;
        }

        internal async Task PrepararDesayuno ()
        {
            Console.WriteLine("Comienza a preparar el cafe");
            Task<int> var1 = prepararCafeAsync();            
            Console.WriteLine("Comienza a preparar la arepa");
            Task var2 = asarArepaAsync();            
            Console.WriteLine("Comienza a preparar el huevo");
            Task var3 = prepararHuevoAsync();

            int x = await var1;
            await var2;
            await var3;

        }
    }
}
