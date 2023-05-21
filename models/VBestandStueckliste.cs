using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestandStueckliste
{
    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public int KStueckliste { get; set; }

    public decimal? FBestand { get; set; }

    public decimal? FBestandEigen { get; set; }

    public decimal? FBestandGesperrtVerfuegbar { get; set; }

    public decimal? FBestandGesperrtAuslieferung { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FZulauf { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public decimal? FAufEinkaufsliste { get; set; }
}
