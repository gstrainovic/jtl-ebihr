using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBestellungPicklisteLock
{
    public int KBestellung { get; set; }

    public int KPickliste { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
