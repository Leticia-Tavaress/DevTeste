using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEpi.Test
{
    [TestClass]
    class FuncionarioEpi
    {
        [TestMethod]
        public void FuncionarioEpi_CriarFuncionarioEpi_RertonaFuncionarioEpi()
        {
            var funcionarioEpiEsperada = new
            {
                FuncionarioEpiId = "1",
                DatEntrega = "18/03/2021",
                DatTroca = "25/08/2021",
                FuncionarioId = "3",
                EpiId = "1"
            };

            var FuncionarioEpi = new FuncionarioEpi(funcionarioEpiEsperada.FuncionarioEpiId, funcionarioEpiEsperada.DatEntrega, funcionarioEpiEsperada.DatTroca, funcionarioEpiEsperada.FuncionarioId, funcionarioEpiEsperada.EpiId);

            Assert.AreEqual(funcionarioEpiEsperada, FuncionarioEpi);
        }
    }
}
