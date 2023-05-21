using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMerkmalwertBildPlattform
{
    public int KMerkmalwertBildPlattform { get; set; }

    public int KMerkmalwert { get; set; }

    public int? KBild { get; set; }

    public int? KPlattform { get; set; }

    public int? KShop { get; set; }

    public byte? NInet { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
