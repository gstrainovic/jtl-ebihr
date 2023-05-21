using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAbrechnung
{
    public int KAbrechnung { get; set; }

    public int KBenutzer { get; set; }

    public int KKunde { get; set; }

    public int KFirma { get; set; }

    public int KFulfillmentLieferant { get; set; }

    public string CAbrechnungsNummer { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public DateTime DAbrechnungVon { get; set; }

    public DateTime? DAbrechnungBis { get; set; }

    public int? KBestellung { get; set; }

    public DateTime? DAuftragErstellt { get; set; }

    public byte? NStorno { get; set; }

    public string? CBestellNr { get; set; }
}
