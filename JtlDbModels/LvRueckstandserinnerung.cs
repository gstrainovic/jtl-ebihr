using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvRueckstandserinnerung
{
    public int KLieferantenBestellungErinnerung { get; set; }

    public DateTime? DErinnerungDatum { get; set; }

    public string? CEigeneBestellnummer { get; set; }

    public string? CBestellungLieferant { get; set; }

    public int? KBestellungLieferant { get; set; }

    public DateTime? DBestellungErstellt { get; set; }

    public int? NBestellungStatus { get; set; }

    public DateTime? DBestellungLieferdatum { get; set; }

    public DateTime? DBestellungGedruckt { get; set; }

    public DateTime? DBestellungGemailt { get; set; }

    public DateTime? DBestellungGefaxt { get; set; }

    public DateTime? DBestellungExportiert { get; set; }

    public string? CBestellungInternerKommentar { get; set; }

    public decimal? FBetragNetto { get; set; }
}
