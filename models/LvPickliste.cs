using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvPickliste
{
    public int KPickliste { get; set; }

    public string? CPicklisteNr { get; set; }

    public int? KWarenLager { get; set; }

    public string? CWarenlagerName { get; set; }

    public int? NStatus { get; set; }

    public byte NLagerplatzVerwaltung { get; set; }

    public string CAnlagebenutzer { get; set; } = null!;

    public DateTime? DZeitstempel { get; set; }

    public DateTime? DGedruckt { get; set; }

    public string CLetzterBenutzer { get; set; } = null!;

    public DateTime? DLetzteBearbeitung { get; set; }

    public string? CVorlage { get; set; }

    public int NType { get; set; }
}
