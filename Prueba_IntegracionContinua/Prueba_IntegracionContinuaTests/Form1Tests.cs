using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba_IntegracionContinua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prueba_IntegracionContinua.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void LoginTest()
        {
            string usuario = "kevin3316";
            string contra = "123";
            bool esperado = true;
            prueba l = new prueba();
            var actua = l.Login(usuario, contra);
            Assert.AreEqual(esperado, actua);            
        }
    }
}