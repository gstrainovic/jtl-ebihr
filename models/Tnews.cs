using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tnews
{
    public int? KNews { get; set; }

    public string? DErstellt { get; set; }

    public string? CBetreff { get; set; }

    public string? CText { get; set; }

    public string? CPicture { get; set; }

    public string? CInet { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
