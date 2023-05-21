using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLieferavisPositionen
{
    public int KLieferavisPosition { get; set; }

    public int KLieferavis { get; set; }

    public int? NPaketNummer { get; set; }

    public int KArtikel { get; set; }

    public string CArtikelnummer { get; set; } = null!;

    public decimal FMenge { get; set; }

    public DateTime? DMhd { get; set; }

    public string? CCharge { get; set; }

    public string? CSeriennummer { get; set; }

    public string? CNotiz { get; set; }

    public string? CJfsku { get; set; }
}
