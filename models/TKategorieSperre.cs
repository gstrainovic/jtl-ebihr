using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TKategorieSperre
{
    public int? KKategorie { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
