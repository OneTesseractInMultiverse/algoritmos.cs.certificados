﻿using System;

namespace Certificados.Negocio.GenerarCertificados
{
    public class CertificadoDigital
    {
        public string Sujeto { get; set; }
        public DateTime FechaDeEmision { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string DireccionDeRevocacion { get; set; }
    }
}