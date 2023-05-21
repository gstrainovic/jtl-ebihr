using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestandVarkombivater
{
    public int KArtikel { get; set; }

    public decimal? FBestand { get; set; }

    public decimal? FBestandEigen { get; set; }

    public decimal? FBestandGesperrtFuerVerfuegbar { get; set; }

    public decimal? FBestandGesperrtFuerAuslieferung { get; set; }

    public decimal? FInAuftraegen { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FZulauf { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public decimal? FAufEinkaufsliste { get; set; }
}
