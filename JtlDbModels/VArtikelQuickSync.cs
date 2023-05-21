using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelQuickSync
{
    public int KArtikel { get; set; }

    public decimal? FLagerbestand { get; set; }

    public decimal FStandardpreisNetto { get; set; }

    public int KShop { get; set; }
}
