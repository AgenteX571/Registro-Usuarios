using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro_Usuarios;

namespace TestUsuarios
{
    [TestClass]
    public sealed class TestMenu
    {
        [TestMethod]
        public void TestMenuPrincipal()
        {
            // probar que el menú se crea correctamente
            var menu = new Menu();
            Assert.IsNotNull(menu);
        }
    }
}
