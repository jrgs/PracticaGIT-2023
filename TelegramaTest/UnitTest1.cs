using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TelegramaTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CalcularCosteTelegramaValido()
        {
            char tipoTelegramaOrdinario = 'o';
            char tipoTelegramaUrgente = 'u';
            int numeroPalabras5 = 5;
            int numeroPalabras20 = 20;
            double resultadoOrdinario5;
            double resultadoUrgente5;
            double resultadoOrdinario20;
            double resultadoUrgente20;

            Telegrama telegrama = new Telegrama();

            resultadoOrdinario5 = telegrama.CalcularCosteTelegrama(tipoTelegramaOrdinario, numeroPalabras5);
            resultadoOrdinario20 = telegrama.CalcularCosteTelegrama(tipoTelegramaOrdinario, numeroPalabras20);

            resultadoUrgente5 = telegrama.CalcularCosteTelegrama(tipoTelegramaUrgente, numeroPalabras5);
            resultadoUrgente20 = telegrama.CalcularCosteTelegrama(tipoTelegramaUrgente, numeroPalabras20);

            Assert.AreEqual(2.5, resultadoOrdinario5, 0.001);
            Assert.AreEqual(7.5, resultadoOrdinario20, 0.001);
            Assert.AreEqual(5, resultadoUrgente5, 0.001);
            Assert.AreEqual(12.5, resultadoUrgente20, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcularCosteTelegramaOrdinarioError()
        {
            char tipoTelegramaOrdinario = 'o';
            int numeroPalabras0 = 0;

            Telegrama telegrama = new Telegrama();

            telegrama.CalcularCosteTelegrama(tipoTelegramaOrdinario, numeroPalabras0);

            Assert.Fail("No ha saltado la excepción esperada");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcularCosteTelegramaUrgenteError()
        {
            char tipoTelegramaUrgente = 'u';
            int numeroPalabras0 = 0;

            Telegrama telegrama = new Telegrama();
            telegrama.CalcularCosteTelegrama(tipoTelegramaUrgente, numeroPalabras0);

            Assert.Fail("No ha saltado la excepción esperada");
        }
    }
}
