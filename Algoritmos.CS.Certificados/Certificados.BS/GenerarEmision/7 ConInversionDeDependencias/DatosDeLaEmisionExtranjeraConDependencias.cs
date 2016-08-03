﻿using Certificados.DS.GenerarEmision;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using System;

namespace Certificados.BS.GenerarEmision.ConInversionDeDependencias
{
    class DatosDeLaEmisionExtranjeraConDependencias: DatosDeLaEmisionNacional
    {
        public override int AñosDeVigencia
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLosAñosDeVigencia();
            }
        }

        public override string DireccionDeRevocacion
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLaDireccionDeRevocacion();
            }
        }

        public override DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}