using System;
using System.Collections.Generic;

namespace AFSoluzioniMVCCoreAuth.Data.EF
{
    public partial class Donatori
    {
        public int DonatoreId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Citta { get; set; }
    }
}
