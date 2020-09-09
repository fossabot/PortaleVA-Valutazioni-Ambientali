﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VALib.Domain.Common;
using VALib.Web;

namespace VALib.Domain.Entities.DatiAmbientali
{
    public class Risorsa : GuidEntity
    {
        public Risorsa()
        {
            Entita = new List<Tuple<string, string>>();
        }
        
        public TipoContenutoRisorsa TipoContenutoRisorsa { get; internal set; }

        public string Url { get; internal set; }

        public string Titolo { get; internal set; }

        public string Soggetto { get; internal set; }

        public DateTime? DataPubblicazione { get; internal set; }

        public DateTime? DataCreazione { get; internal set; }

        public DateTime? DataScadenza { get; internal set; }

        public string Abstract { get; internal set; }

        public string Origine { get; internal set; }

        public string Commenti { get; internal set; }

        public string Scopo { get; internal set; }

        public string ParoleChiave { get; internal set; }

        public string Riferimenti { get; internal set; }

        public string Diritti { get; internal set; }

        public string Argomenti { get; internal set; }

        public List<Tuple<string, string>> Entita { get; internal set; }

        public string GetUrl()
        {
            string result = "";

            switch (TipoContenutoRisorsa.FileIcona.ToLower())
            {
                case "icostrato.gif":
                case "progettocartografico.gif":
                case "interactiveresource.gif":
                    result = Url;
                    break;
                default:
                    result = Url;//UrlUtility.VARisorsaDatiAmbientali(ID);
                    break;
            }

            return result;
        }
    }
}
