using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelDimension
{
    public int KArtikelDimension { get; set; }

    public int KArtikel { get; set; }

    public int KDimension { get; set; }

    public decimal FWert { get; set; }

    public int? KMasseinheit { get; set; }

    public decimal? FMinWert { get; set; }

    public decimal? FMaxWert { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TDimension KDimensionNavigation { get; set; } = null!;

    public virtual TMassEinheit? KMasseinheitNavigation { get; set; }
}
