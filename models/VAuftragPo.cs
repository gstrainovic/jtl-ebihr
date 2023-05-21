using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragPo
{
    public int KFulfillmentAuftragPos { get; set; }

    public int? KFulfillmentAuftrag { get; set; }

    public int? KArtikel { get; set; }

    public string? CJfsku { get; set; }

    public decimal FAnzahl { get; set; }

    public string? CPosName { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CHinweis { get; set; }

    public int? NSort { get; set; }

    public decimal? FVknetto { get; set; }

    public decimal FMwSt { get; set; }

    public string? COrderItemId { get; set; }

    public int NStuecklistenVater { get; set; }

    public int KStuecklistenVaterPos { get; set; }

    public int KLieferscheinPos { get; set; }
}
