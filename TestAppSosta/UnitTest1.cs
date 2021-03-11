using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgettoAppSosta;

namespace TestAppSosta
{
    [TestClass]
    public class TestVerifica
    {
        [TestMethod]
        public void tariffa1()
        {
            int ore = 3;
            double tariffa = 15;
            double risposta_aspettata = 15;
            double risposta_effettiva = Gestione.tariffaA(ore, tariffa);
            Assert.AreEqual(risposta_effettiva, risposta_aspettata);
        }
        [TestMethod]
        public void tariffaB()
        {
            int ore = 3;
            double tariffa = 1;
            double risposta_aspettata = 3;
            double risposta_effettiva = Gestione.tariffaB(ore, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }
        [TestMethod]
        public void tariffaC()
        {
            int ore = 2;
            double tariffa = 1.20;
            double risposta_aspettata = 1.20;
            double risposta_effettiva = Gestione.tariffaC(ore, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }
    }
}
