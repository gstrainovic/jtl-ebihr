using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenlagerArtikelOptionen
{
    public int KArtikel { get; set; }

    public int KWarenlager { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int? KWmslagerBereich { get; set; }

    public decimal FMindestMenge { get; set; }

    public decimal FVorschlag { get; set; }

    public decimal FNachschiebenAb { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
