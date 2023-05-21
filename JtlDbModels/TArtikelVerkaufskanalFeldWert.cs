using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelVerkaufskanalFeldWert
{
    public int KArtikelVerkaufskanalFeldWert { get; set; }

    public int KShopScx { get; set; }

    public int KArtikel { get; set; }

    public string? CAttributeId { get; set; }

    public string CWert { get; set; } = null!;

    public string? CName { get; set; }

    public bool NIsDotLiquidValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NReferenzGruppe { get; set; }

    public int? Kfile { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TShopScx KShopScxNavigation { get; set; } = null!;

    public virtual TFile? KfileNavigation { get; set; }
}
