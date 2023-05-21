using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsErinnerung
{
    public int KZahlungsErinnerung { get; set; }

    public int KRechnung { get; set; }

    public int KMahnstufe { get; set; }

    public int KFirma { get; set; }

    public int KKundengruppe { get; set; }

    public byte NMahnstufeAktuell { get; set; }

    public DateTime? DZahlungsfrist { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DMahndatum { get; set; }

    public DateTime? DErledigt { get; set; }

    public decimal FGebuehr { get; set; }

    public int? NKarenzzeit { get; set; }

    public int? NZahlungsfristInTagen { get; set; }

    public decimal FGebuehrPauschal { get; set; }

    public decimal FGebuehrZinssatz { get; set; }

    public string? CKommentar { get; set; }

    public decimal? FBruttoBetrag { get; set; }

    public int? KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
