﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VALib.Domain.Common;

namespace VALib.Domain.Entities.DatiAmbientali
{
    public class Tema : Entity
    {
        public string Nome { get; internal set; }
    }
}
