using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayMapitemSuchString
{
    public int KEbayMapitemSuchString { get; set; }

    public string CSuchStringAnfang { get; set; } = null!;

    public string CSuchStringEnde { get; set; } = null!;

    public byte NSource { get; set; }
}
