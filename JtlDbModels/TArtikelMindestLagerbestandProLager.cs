using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelMindestLagerbestandProLager
{
    public int KArtikelMindestLagerbestandProLager { get; set; }

    public int KArtikel { get; set; }

    public int KWarenlager { get; set; }

    public decimal? FMindestbestand { get; set; }

    public decimal? FMaximalbestand { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TWarenLager KWarenlagerNavigation { get; set; } = null!;
}
