﻿using Sujetos;

namespace Certificados.Negocio.GenerarCertificados.ConPolimorfismo
{
    public class DatosParaUnCertificadoDigitalNacionalDeAutenticacion : DatosParaUnCertificadoDigital
    {
        public override InformacionFormateada InformacionFormateada
        {
            get
            {
                return new InformacionNacionalDeAutenticacion();
            }
        }
    }
}
