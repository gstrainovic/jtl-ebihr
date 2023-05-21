using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBestellungSperre
{
    public int? KBestellung { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
