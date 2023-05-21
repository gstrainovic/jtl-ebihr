using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerkmalGruppe
{
    public int KMerkmalGruppe { get; set; }

    public string? CName { get; set; }

    public int? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
