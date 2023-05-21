using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMahnstufe
{
    public int KMahnstufe { get; set; }

    public int KFirma { get; set; }

    public int KKundengruppe { get; set; }

    public byte NStufe { get; set; }

    public int? NKarenzzeit { get; set; }

    public int? NZahlungsfristInTagen { get; set; }

    public decimal FGebuehrPauschal { get; set; }

    public decimal FGebuehrZinssatz { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
