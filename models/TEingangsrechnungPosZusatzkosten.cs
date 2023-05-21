using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEingangsrechnungPosZusatzkosten
{
    public int KZusatzkosten { get; set; }

    public int KEingangsrechnungPos { get; set; }

    public decimal DWert { get; set; }

    public decimal FFremdFaktor { get; set; }

    public string? CWaehrungIso { get; set; }

    public decimal FMwst { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
