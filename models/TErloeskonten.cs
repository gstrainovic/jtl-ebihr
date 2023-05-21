using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TErloeskonten
{
    public int KErloeskonten { get; set; }

    public string? CName { get; set; }

    public byte? NType { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
