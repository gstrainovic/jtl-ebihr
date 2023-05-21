using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelRankingZeitraum
{
    public int KArtikel { get; set; }

    public byte NZeitraum { get; set; }

    public DateTime DVon { get; set; }

    public byte NType { get; set; }

    public int KShop { get; set; }

    public int NPlattform { get; set; }

    public int NRang { get; set; }

    public int? NRangMax { get; set; }

    public decimal NAnteilProzent { get; set; }

    public decimal NPauschal { get; set; }

    public DateTime? DStand { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
