using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferscheinEckdaten
{
    public DateTime? DErstellt { get; set; }

    public int KLieferschein { get; set; }

    public DateTime? DVersendet { get; set; }

    public int NAnzahlPakete { get; set; }

    public int NAnzahlVersendetePakete { get; set; }

    public byte? NVersandStatus { get; set; }

    public int? KVersandArt { get; set; }

    public byte NRechnungStatus { get; set; }

    public decimal FArtikelGewicht { get; set; }

    public decimal FVersandGewicht { get; set; }

    public virtual TLieferschein KLieferscheinNavigation { get; set; } = null!;
}
