﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppJuegos:Aplicacion
    {
        protected override int Tamanio
        {
            get { return this.tamanioMB; }
        }
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB) : base(nombre, sistemaOperativo, tamanioMB)
        {
        }

    }
}
