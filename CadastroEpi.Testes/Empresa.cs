using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CadastroEpi.Testes
{
    [TestClass]
    public class Empresa
    {
        [TestMethod]
        public void Empresa_CriarEmpresa_RetornarEmpresa()
        {

            var empresaEsperado = new
            {
                EmpresaId = "1",
                TipoIdentificador = "CPF",
                Identificador = "12345678998",
                RazaoSocial = "LTDA"                
            };

            var Empresa = new Empresa(empresaEsperado.EmpresaId, empresaEsperado.TipoIdentificador, empresaEsperado.Identificador, empresaEsperado.RazaoSocial);

            Assert.AreEqual(empresaEsperado, Empresa);
            
        }
    }
}
