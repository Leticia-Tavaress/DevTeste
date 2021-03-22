using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEpi.Test
{
    [TestClass]
    class Funcionario
    {
        [TestMethod]
        public void Funcionario_CriarFuncionario_RertonaFuncionario()
        {
            var funcionarioEsperada = new
            {
                FuncionarioId = "1",
                NomeFuncionario = "Pedro",
                Cpf = "7894561233214",
                FuncaoId = "2"
            };

            var Funcionario = new Funcionario(funcionarioEsperada.FuncionarioId, funcionarioEsperada.NomeFuncionario, funcionarioEsperada.Cpf, funcionarioEsperada.FuncaoId);

            Assert.AreEqual(funcionarioEsperada, Funcionario);
        }
    }
}
