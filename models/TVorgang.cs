using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVorgang
{
    public int KVorgang { get; set; }

    public int KVorgangType { get; set; }

    public string? CFfnKey { get; set; }

    public int? KWawiKey { get; set; }

    public string? CWawiNumber { get; set; }

    public int? KLieferant { get; set; }

    public int? KLieferschein { get; set; }

    public int? KArtikelHistory { get; set; }

    public int? KWarenlager { get; set; }

    public int? KAuftrag { get; set; }

    public int? KLieferantenBestellung { get; set; }

    public int? KFulfillmentAuftrag { get; set; }

    public int? KArtikel { get; set; }

    public int? KKunde { get; set; }

    public DateTimeOffset? DErrorSince { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public int? NErrorCount { get; set; }

    public string? CComment { get; set; }

    public virtual TVorgangType KVorgangTypeNavigation { get; set; } = null!;

    public virtual ICollection<TVorgangQueue> TVorgangQueues { get; set; } = new List<TVorgangQueue>();
}
