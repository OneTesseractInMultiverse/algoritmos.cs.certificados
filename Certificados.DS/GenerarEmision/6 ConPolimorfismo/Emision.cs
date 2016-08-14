﻿using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using System;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class Emision
    {
        private DateTime laFechaActual;
        private CertificadoDigital elCertificadoDeAutenticacion;
        private CertificadoDigital elCertificadoDeFirma;

        public Emision(DatosDeLaEmision losDatosDeLaEmision)
        {
            laFechaActual = losDatosDeLaEmision.FechaActual;
            elCertificadoDeAutenticacion = ObtengaElCertificadoDeAutenticacion(losDatosDeLaEmision);
            elCertificadoDeFirma = ObtengaElCertificadoDeFirma(losDatosDeLaEmision);
        }

        private static CertificadoDigital ObtengaElCertificadoDeAutenticacion(DatosDeLaEmision losDatosDeLaEmision)
        {
            return new CertificadoDeAutenticacion(losDatosDeLaEmision).Generado();
        }

        private static CertificadoDigital ObtengaElCertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            return new CertificadoDeFirma(losDatosDeLaEmision).Generado();
        }

        public DateTime FechaDeGeneracion
        {
            get { return laFechaActual; }
        }

        public CertificadoDigital CertificadoDeAutenticacion
        {
            get { return elCertificadoDeAutenticacion; }
        }

        public CertificadoDigital CertificadoDeFirma
        {
            get { return elCertificadoDeFirma; }
        }
    }
}