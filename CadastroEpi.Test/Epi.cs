using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEpi.Test
{
    [TestClass]
    class Epi
    {
        [TestMethod]
        public void Epi_CriarEpi_RertonaEpi()
        {
            var EpiEsperada = new
            {
                EpiId = "1",
                NomEpi = "Luva",
                DatInclusao = "18/03/2021",
                DatValidade = "25/08/2021",
                NomeFabricante = "LTDA",
                CnpjFabricante= "1234567899632147"
             
            };

            var Epi = new Epi(EpiEsperada.EpiId, EpiEsperada.NomEpi, EpiEsperada.DatInclusao, EpiEsperada.DatValidade, EpiEsperada.NomeFabricante, EpiEsperada.CnpjFabricante);

            Assert.AreEqual(EpiEsperada, Epi);
        }
    }
}
