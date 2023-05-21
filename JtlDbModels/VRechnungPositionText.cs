using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungPositionText
{
    public int KRechnungPosition { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
