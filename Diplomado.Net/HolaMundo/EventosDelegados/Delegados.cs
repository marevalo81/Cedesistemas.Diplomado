using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.EventosDelegados
{
    public delegate void Del(string message);
    public static class Delegados
    {
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void DelegateMethod2(string message)
        {
            Console.WriteLine($"Soy el segundo delegado {message}");
        }

        public static void DelegateMethod3(string message)
        {
            Console.WriteLine($"Soy el tercer delegado {message}");
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            int suma = param1 + param2;
            callback($"La suma es: {suma.ToString()}");
        }
    }
}
