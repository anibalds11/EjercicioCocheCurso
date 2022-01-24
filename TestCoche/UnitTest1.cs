using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CocheApp;

namespace TestCoche
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckEstado()
        {
            Rueda rueda1 = CreateRueda();
            Coche coche1 = CreateCoche(rueda1);

            coche1.arrancar();

            Assert.IsTrue(coche1.estado);

            coche1.apagar();

            Assert.IsFalse(coche1.estado);

        }

        [TestMethod]
        public void CheckMovimiento()
        {
            Rueda rueda1 = CreateRueda();
            Coche coche1 = CreateCoche(rueda1);

            coche1.arrancar();

            Assert.IsTrue(coche1.rueda.movimiento);

            coche1.apagar();

            Assert.IsFalse(coche1.rueda.movimiento);
        }


        private Rueda CreateRueda()
        {
            Rueda r = new Rueda(false);
            return r;
        }

        private Coche CreateCoche(Rueda r)
        {
            Coche coche = new Coche(false,r);
            return coche;
        }
    }
}
