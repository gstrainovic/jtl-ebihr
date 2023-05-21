using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKundenKategorie
{
    public int KKundenKategorie { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
