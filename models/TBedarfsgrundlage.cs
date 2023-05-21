using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBedarfsgrundlage
{
    public int KBedarfsgrundlage { get; set; }

    public string CName { get; set; } = null!;

    public byte NAktiv { get; set; }

    public byte NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
