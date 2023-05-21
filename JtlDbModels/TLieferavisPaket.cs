using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferavisPaket
{
    public int KLieferavisPaket { get; set; }

    public int KLieferavis { get; set; }

    public int NPaketNummer { get; set; }

    public string CVersanddienstleister { get; set; } = null!;

    public string? CTrackingId { get; set; }

    public string? CTrackingUrl { get; set; }

    public decimal? FGewicht { get; set; }

    public DateTime? DVersanddatum { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public int NFrachtart { get; set; }

    public int NStatus { get; set; }

    public string CNotiz { get; set; } = null!;

    public decimal? FBreite { get; set; }

    public decimal? FTiefe { get; set; }

    public decimal? FHoehe { get; set; }

    public int? NAnzahlFrachtstuecke { get; set; }

    public virtual TLieferavi KLieferavisNavigation { get; set; } = null!;

    public virtual ICollection<TLieferavisIdentifier> TLieferavisIdentifiers { get; set; } = new List<TLieferavisIdentifier>();
}
