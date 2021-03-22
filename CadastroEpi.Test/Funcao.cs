using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEpi.Test
{
    [TestClass]
    class Funcao
    {
        [TestMethod]
        public void Funcao_CriarFuncao_RertonaFuncao()
        {
            var funcaoEsperada = new
            {
                FuncaoId = "1",
                NomeFuncao = "Operador de maquinas",
                EmpresaId = "2",
                EpiId ="1"
            };

            var Funcao = new Funcao(funcaoEsperada.FuncaoId, funcaoEsperada.NomeFuncao, funcaoEsperada.EmpresaId, funcaoEsperada.EpiId);

            Assert.AreEqual(funcaoEsperada, Funcao);
        }
    }
}
