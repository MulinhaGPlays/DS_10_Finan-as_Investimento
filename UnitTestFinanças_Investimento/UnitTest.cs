using Microsoft.VisualStudio.TestTools.UnitTesting;
using Finanças_Investimento;

namespace UnitTestFinanças_Investimento
{
    [TestClass]
    public class UnitTestFinanças_Investimento
    {
        [TestMethod]
        public void TestMethodFinanças_Investimento()
        {
            Test teste = new Test();

            double EntradaInvestidor = 1400;
            bool Esperado = true;
            bool Resultado = false;
            double Implementacao;
            int Meses = 24;

            if(teste.Juros(EntradaInvestidor) == 1602.86){
                Resultado = true
            }

            Assert.AreEqual(Esperado, Resultado);
        }
    }
}
