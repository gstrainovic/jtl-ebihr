using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvRetouren
{
    public int KKunde { get; set; }

    public int KRmretoure { get; set; }

    public int? KBestellungUmtausch { get; set; }

    public int? KGutschrift { get; set; }

    public string CRetoureNr { get; set; } = null!;

    public DateTime DErstellt { get; set; }

    public byte NStatusTyp { get; set; }

    public string? Warenlagername { get; set; }

    public string Status { get; set; } = null!;

    public string? Firma { get; set; }

    public string? BestellNr { get; set; }
}
