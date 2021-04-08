using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Tupla
{
    public class tuplas
    {
        public (int min, int max) FindMinMax(int x, int y)
        {
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            return (min, max);
        }

        public (List<TransactionCost>,int) CostosTransaccion()
        {
            List<TransactionCost> costos = new List<TransactionCost>();
            costos.Add(new TransactionCost() { category = "T", maxValue = 100000, minValue = 0, valor = 3800 });
            costos.Add(new TransactionCost() { category = "T", maxValue = 5000, minValue = 0, valor = 3800 });
            costos.Add(new TransactionCost() { category = "C", maxValue = 100000, minValue = 0, valor = 5000 });
            int multiplo = 10000;
            return (costos,multiplo);
        }
    }
}
