using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tkonfiggruppe
{
    public int KKonfiggruppe { get; set; }

    public byte[]? Bild { get; set; }

    public int? NMin { get; set; }

    public int? NMax { get; set; }

    public int? NTyp { get; set; }

    public int? NSort { get; set; }

    public string? CKommentar { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<Tartikelkonfiggruppe> Tartikelkonfiggruppes { get; set; } = new List<Tartikelkonfiggruppe>();
}
