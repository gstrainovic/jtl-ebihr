using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayItem2kombi
{
    public int KItem { get; set; }

    public int KEigenschaftKombi { get; set; }

    public decimal FPreis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FMaxAnzahl { get; set; }

    public string? CEan { get; set; }

    public decimal FMinAnzahl { get; set; }

    public decimal? FStreichPreis { get; set; }

    public string? CStreichPreisTyp { get; set; }
}
