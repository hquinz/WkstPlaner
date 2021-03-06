﻿namespace HtlWeiz.WkstPlaner.Model.tables
{
    public partial class TblKlassenSchueler
    {
        public int KlasseId { get; set; }
        public string Schuelerkennzahl { get; set; }
        public byte? Gruppe { get; set; }

        public virtual TblKlassen Klasse { get; set; }
        public virtual TblSchueler SchuelerkennzahlNavigation { get; set; }
    }
}
