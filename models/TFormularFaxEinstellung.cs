using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFormularFaxEinstellung
{
    public int KFormularFaxEinstellung { get; set; }

    public int KFormular { get; set; }

    public string? CRechnername { get; set; }

    public int? KBenutzer { get; set; }

    public string CFaxname { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
