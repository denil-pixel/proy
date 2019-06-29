using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TextValidarDatos()
        {
            string input = "566";
            bool output = true ,salida;
            salida= Formulario_Validado.Validacion.isEntero(input);
            Assert.AreEqual(output, salida);
            input = "24544444444444444444444444444444";
            output = false;


     
        }
        [TestMethod]
        public void TestEmail()
        {
            string input = "asas";
            bool salida;
            salida = Formulario_Validado.Validacion.isEmail("assd.cvom");
            Assert.IsFalse(salida);
            salida = Formulario_Validado.Validacion.isEmail("assda.com");
            Assert.IsTrue(salida);
        }
    }
}
