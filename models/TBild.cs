using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBild
{
    public int KBild { get; set; }

    public string CQuelle { get; set; } = null!;

    public byte[] BBild { get; set; } = null!;

    public int NDateigroesse { get; set; }

    public int NBreite { get; set; }

    public int NHoehe { get; set; }

    public string CHash { get; set; } = null!;

    public string CChecksum { get; set; } = null!;

    public byte[] BVorschauBild { get; set; } = null!;

    public int NVorschauDateigroesse { get; set; }

    public int NVorschauBreite { get; set; }

    public int NVorschauHoehe { get; set; }

    public DateTime DErstellt { get; set; }

    public DateTime DAenderung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
