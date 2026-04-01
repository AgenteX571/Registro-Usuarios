namespace Registro_Usuarios_Test
{
    [TestClass]
    public sealed class TestValidaciones
    {
        // Instancias de las clases de lógica de negocios
        Logica_Negocios.Negocio_Usuarios logica_user = new Logica_Negocios.Negocio_Usuarios();
        Logica_Negocios.Negocio_Cliente logica_cliente = new Logica_Negocios.Negocio_Cliente();
        Logica_Negocios.Negocio_Empleados logica_empleado = new Logica_Negocios.Negocio_Empleados();

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

        [TestMethod]
        public void TestClienteTrue()
        {
            bool resultado = logica_cliente.VerificarCliente("Juan Marti", 19, "Juan@gmail..com");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestClienteFalse()
        {
            bool resultado = logica_cliente.VerificarCliente("hjabsdh ad", 300, "ajsbdhgash");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestEmpleadoTrue()
        {
            bool resultado = logica_empleado.VerificarEmpleado("Daniel Augusto", 20, "MartineZapata@gmail.com", "Senior Developer");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEmpleadoFalse()
        {
            bool resultado = logica_empleado.VerificarEmpleado("asdasd asdas", 300, "asdasd", "asdasd");
            Assert.IsFalse(resultado);
        }
    }
}