using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteInBoxLock
{
    public int KLhm { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DZeitstempel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
