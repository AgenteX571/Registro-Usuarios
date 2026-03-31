namespace TestUsuarios
{
    [TestClass]
    public sealed class TestUsuarios
    {
        Logica_Negocios.Negocio_Usuarios logica_usuario = new Logica_Negocios.Negocio_Usuarios();

        [TestMethod]
        public void TestValidarUsuarioTrue()
        {
            bool result = logica_usuario.ValidarUsuario("Daniel", "12345");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidarUsuarioFalse()
        {
            bool result = logica_usuario.ValidarUsuario("Daniel", "54321");
            Assert.IsFalse(result);
        }
    }
}
