﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VALib.Domain.Entities.Contenuti;

namespace VAPortale.Models
{
    public class EventiRaggruppamentiTreeViewModel
    {
        public EventiRaggruppamentiTreeViewModel()
        {
            Raggruppamenti = new List<Raggruppamento>();
        }
        
        public int EventoID { get; set; }

        public int GenitoreID { get; set; }

        public int RaggruppamentoID { get; set; }

        public List<Raggruppamento> Raggruppamenti { get; set; }
    }
}