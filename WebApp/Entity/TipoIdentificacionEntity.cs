﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoIdentificacionEntity: DBEntity
    {
        public int? IdTipoIdentificacion { get; set; }
        public string Descripcion { get; set; }
    }
}
