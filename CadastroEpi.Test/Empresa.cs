using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CadastroEpi.Test
{
    [TestClass]
    public class Empresa
    {
        [TestMethod]
        public void Empresa_CriarEmpresa_RertonaEmpresa()
        {
            var empresaEsperada = new
            {
                EmpresaId = "1",
                TipoIdentificador = "CPF",
                Identificador = "12345678998",
                RazaoSocial = "LTDA"
            };

            var Empresa = new Empresa(empresaEsperada.EmpresaId, empresaEsperada.TipoIdentificador, empresaEsperada.Identificador, empresaEsperada.RazaoSocial);

            Assert.AreEqual(empresaEsperada, Empresa);
        }
    }
}
