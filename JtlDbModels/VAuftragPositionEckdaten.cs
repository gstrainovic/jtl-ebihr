using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragPositionEckdaten
{
    public int KAuftragPosition { get; set; }

    public int NArtikelTyp { get; set; }

    public decimal FAnzahlOffen { get; set; }

    public decimal FAnzahlGeliefert { get; set; }

    public decimal FAnzahlGutgeschrieben { get; set; }

    public bool NIstDropshippingLieferbar { get; set; }

    public decimal? FWert { get; set; }

    public bool NIstKomplettRetourniert { get; set; }

    public decimal FTeilmengenfaktorLager { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KArtikel { get; set; }

    public bool NIstStuecklistenvater { get; set; }

    public bool NIstUmlagerung { get; set; }

    public int KAuftrag { get; set; }

    public byte? NAuftragStatus { get; set; }
}
