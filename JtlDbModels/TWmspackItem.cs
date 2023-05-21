using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWmspackItem
{
    public int KWmspackItem { get; set; }

    public int KArtikel { get; set; }

    public decimal FMenge { get; set; }

    public int KPickliste { get; set; }

    public int KBestellung { get; set; }

    public int? KBestellpos { get; set; }

    public int? KBestellStueckliste { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NTyp { get; set; }

    public int? KKartonLagerPlatz { get; set; }
}
