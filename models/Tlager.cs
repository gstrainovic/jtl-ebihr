using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tlager
{
    public int KLager { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
