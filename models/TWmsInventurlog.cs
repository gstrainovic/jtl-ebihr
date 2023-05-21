using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmsInventurlog
{
    public int KWmsInventurlog { get; set; }

    public int? KWmsInventur { get; set; }

    public int? KWarenlagerPlatz { get; set; }

    public int? KArtikel { get; set; }

    public DateTime? DMhd { get; set; }

    public string? CCharge { get; set; }

    public decimal FAnzahl { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public int? KBenutzer { get; set; }

    public decimal FDifferenz { get; set; }

    public int? NTyp { get; set; }

    public int? KWarenLagerEingangSubset { get; set; }
}
