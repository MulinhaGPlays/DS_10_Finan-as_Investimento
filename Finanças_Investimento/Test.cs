using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanças_Investimento.Class
{
    public class Teste
    {
        public double Juros(double Implementacao, double EntradaInvestidor, int Meses)
        {
            Implementacao = EntradaInvestidor * (Math.Pow((1 + 0.07), Meses / 12));
            return Implementacao - EntradaInvestidor;
        }
    }
}
