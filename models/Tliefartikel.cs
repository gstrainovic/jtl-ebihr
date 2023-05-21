using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tliefartikel
{
    public int KLiefArtikel { get; set; }

    public int TArtikelKArtikel { get; set; }

    public int TLieferantKLieferant { get; set; }

    public decimal FEkbrutto { get; set; }

    public decimal FEknetto { get; set; }

    public string? CLiefArtNr { get; set; }

    public string? CWaehrung { get; set; }

    public string? CLiefFrist { get; set; }

    public int? NLieferbar { get; set; }

    public string? CSonstiges { get; set; }

    public byte NStandard { get; set; }

    public int? NMindestAbnahme { get; set; }

    public decimal NAbnahmeIntervall { get; set; }

    public decimal FLagerbestand { get; set; }

    public int? NLieferzeit { get; set; }

    public byte? NDropShipping { get; set; }

    public byte? NDropShippingStandard { get; set; }

    public string? CName { get; set; }

    public decimal FDurchschnittlicheLieferzeit { get; set; }

    public byte? NLagerBeachten { get; set; }

    public DateTime? DLbgeaendert { get; set; }

    public string? CVpeeinheit { get; set; }

    public decimal? NVpemenge { get; set; }

    public decimal FMwSt { get; set; }

    public byte NLieferzeitAusLieferant { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TArtikel TArtikelKArtikelNavigation { get; set; } = null!;

    public virtual Tlieferant TLieferantKLieferantNavigation { get; set; } = null!;
}
