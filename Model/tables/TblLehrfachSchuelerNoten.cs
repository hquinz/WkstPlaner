﻿namespace HtlWeiz.WkstPlaner.Model.tables
{
    public partial class TblLehrfachSchuelerNoten
    {
        public int KlassenLehrfachId { get; set; }
        public string Schuelerkennzahl { get; set; }
        public string Note { get; set; }

        public virtual TblKlassenLehrfaecher KlassenLehrfach { get; set; }
        public virtual TblSchueler SchuelerkennzahlNavigation { get; set; }
    }
}
