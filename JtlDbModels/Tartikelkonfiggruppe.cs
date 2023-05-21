using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tartikelkonfiggruppe
{
    public int KArtikelkonfiggruppe { get; set; }

    public int KArtikel { get; set; }

    public int KKonfiggruppe { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual Tkonfiggruppe KKonfiggruppeNavigation { get; set; } = null!;
}
