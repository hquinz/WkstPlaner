﻿namespace HtlWeiz.WkstPlaner.Model.tables
{
    public partial class TblKlassenGruppenReihenfolge
    {
        public int KlasseId { get; set; }
        public byte Gruppe { get; set; }
        public int? Turnus { get; set; }

        public virtual TblKlassen Klasse { get; set; }
    }
}
