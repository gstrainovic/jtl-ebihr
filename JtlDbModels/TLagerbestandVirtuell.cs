using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLagerbestandVirtuell
{
    public int KLagerbestandVirtuell { get; set; }

    public int KArtikel { get; set; }

    public Guid IModuleId { get; set; }

    public decimal FBestand { get; set; }

    public bool NLagerBeachten { get; set; }

    public DateTime? DGeandert { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal FZulauf { get; set; }
}
