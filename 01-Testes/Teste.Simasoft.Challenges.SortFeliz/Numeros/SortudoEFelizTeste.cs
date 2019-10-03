using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simasoft.Challenges.SortFeliz.UI.Numeros;

namespace Teste.Simasoft.Challenges.SortFeliz.Numeros
{
    [TestClass]
    public class SortudoEFelizTeste
    {
        
        [TestMethod]
        [DataRow(7)]
        [DataRow(21)]
        [DataRow(28)]
        [DataRow(142)]
        [DataRow(37)]
        [DataRow(100)]        
        public void ValidaSeNumeroESortudoEFeliz(int numero)
        {
            string resultado = new SortudoEFeliz(numero).ImprimeResultadoGeral();
        }
    }
}