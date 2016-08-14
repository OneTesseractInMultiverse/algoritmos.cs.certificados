﻿using Sujetos;
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class CertificadoDeFirma
    {
        private InformacionFormateada laInformacionDeFirma;

        public CertificadoDeFirma(DatosDeLaEmision losDatosDeLaEmision)
        {
            laInformacionDeFirma = losDatosDeLaEmision.InformacionDeFirma;
        }

        public CertificadoDigital Generado()
        {
            return new CertificadoDigital(laInformacionDeFirma);
        }
    }
}