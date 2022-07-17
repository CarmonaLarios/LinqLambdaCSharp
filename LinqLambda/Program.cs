using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //var query= from num in salarios where num>1000 select num;
            //foreach (var i in query)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            double[] salarios = { 300 ,500,10000};
            List<Salario> personSalario = new List<Salario>();

            foreach (var s in salarios)
            {
                personSalario.Add(new Salario(s));
            }

            var query = from num in personSalario where num.getSalario() > 100 select num;

            foreach (var i in query)
            {
                Console.WriteLine(i.getSalario());
            }

            Console.ReadKey();
        }
    }
}
