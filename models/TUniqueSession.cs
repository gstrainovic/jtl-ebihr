using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUniqueSession
{
    public int KSession { get; set; }

    public string CContext { get; set; } = null!;

    public DateTime DLastCallback { get; set; }

    public string? CInfo { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CRechnername { get; set; }
}
