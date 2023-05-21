using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBestellvorschlagVorlage
{
    public int KBestellvorschlagVorlage { get; set; }

    public string CName { get; set; } = null!;

    public string? XKonfiguration { get; set; }

    public byte NAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
