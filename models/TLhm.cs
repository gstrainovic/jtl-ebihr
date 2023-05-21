using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLhm
{
    public int KLhm { get; set; }

    public int? KLhmtyp { get; set; }

    public string? CLhmid { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int? KWarenlager { get; set; }

    public byte? NSperre { get; set; }

    public int? KLhmstatus { get; set; }

    public int? KBenutzer { get; set; }

    public DateTime? DBearbeitet { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
