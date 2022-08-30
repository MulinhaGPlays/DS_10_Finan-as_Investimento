using Microsoft.VisualStudio.TestTools.UnitTesting;
using Finanças_Investimento;
using System;

namespace UnitTestFinanças_Investimento
{
    [TestClass]
    public class UnitTestFinanças_Investimento
    {
        [TestMethod]
        public void TestMethodFinanças_Investimento()
        {
            double Esperado = 1602.86;
            double EntradaInvestidor = 1400;
            double Implementacao;
            int Meses = 24;
            Implementacao = EntradaInvestidor * (Math.Pow((1 + 0.07), Meses / 12));

            Assert.AreEqual(Esperado, Implementacao);
        }
    }
}
