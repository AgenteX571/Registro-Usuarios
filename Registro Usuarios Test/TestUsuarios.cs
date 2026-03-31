namespace Registro_Usuarios_Test
{
    [TestClass]
    public sealed class TestUsuarios
    {
        Logica_Negocios.Negocio_Usuarios logica_user = new Logica_Negocios.Negocio_Usuarios();

        [TestMethod]
        public void TestLoginTrue()
        {
            bool resultado = logica_user.ValidarUsuario("Daniel", "12345");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool resultado = logica_user.ValidarUsuario("Daniel", "54321");
            Assert.IsFalse(resultado);
        }
    }
}