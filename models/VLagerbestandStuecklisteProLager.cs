using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLagerbestandStuecklisteProLager
{
    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public int KStueckliste { get; set; }

    public decimal? FLagerbestand { get; set; }

    public decimal? FAuslieferungGesperrt { get; set; }

    public int KWarenlager { get; set; }
}
