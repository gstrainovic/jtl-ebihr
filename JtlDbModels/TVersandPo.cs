using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandPo
{
    public int KVersand { get; set; }

    public int KLieferscheinPos { get; set; }

    public decimal FAnzahl { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
