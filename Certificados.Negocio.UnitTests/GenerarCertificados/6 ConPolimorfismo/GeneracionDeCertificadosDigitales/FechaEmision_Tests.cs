﻿using System;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Certificados.Negocio.UnitTests.GenerarCertificados.ConPolimorfismo
{
    [TestClass]
    public class FechaEmision_Tests: EscenariosDeCertificados
    {
        private CertificadoDigital elCertificado;
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod]
        public void FechaEmision_UnaFechaActual_LaMismaFechaDeEmision()
        {
            elResultadoEsperado = new DateTime(2016, 10, 11);

            elCertificado = ObtengaUnCertificadoNacionalDeAutenticacion();
            elResultadoObtenido = elCertificado.FechaDeEmision;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}