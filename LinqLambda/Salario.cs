using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    class Salario
    {
        private double salarioMes;

        public Salario(double _salarioMes)
        {
         salarioMes = _salarioMes;
        }

       public void setSalario(double _salarioMes)
        {
            salarioMes = _salarioMes;
        }

        public double getSalario()
        {
            return salarioMes;
        }

    }
}
