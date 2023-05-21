using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklistePosStatus
{
    public int KPicklistePosStatus { get; set; }

    public int KPicklistePos { get; set; }

    public int? Kbenutzer { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public int? NStatus { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
