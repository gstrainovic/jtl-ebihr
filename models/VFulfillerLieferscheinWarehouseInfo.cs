using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFulfillerLieferscheinWarehouseInfo
{
    public string? COutboundId { get; set; }

    public int KBestellung { get; set; }

    public string CBestellNr { get; set; } = null!;

    public int KLieferschein { get; set; }

    public int KWarenLager { get; set; }

    public byte NLagerplatzVerwaltung { get; set; }

    public string? CLieferscheinNr { get; set; }
}
