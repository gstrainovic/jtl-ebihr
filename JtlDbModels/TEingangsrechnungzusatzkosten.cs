using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEingangsrechnungzusatzkosten
{
    public int KZusatzkosten { get; set; }

    public string? CName { get; set; }

    public byte? NGld { get; set; }

    public byte? NPreis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
