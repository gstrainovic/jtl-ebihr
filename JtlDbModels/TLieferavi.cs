using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferavi
{
    public int KLieferavis { get; set; }

    public int KLieferantenBestellung { get; set; }

    public DateTime DErstellt { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public string CNummer { get; set; } = null!;

    public string? CNotiz { get; set; }

    public virtual TLieferantenBestellung KLieferantenBestellungNavigation { get; set; } = null!;

    public virtual TInboundShippingNotificationRef? TInboundShippingNotificationRef { get; set; }

    public virtual ICollection<TLieferavisPaket> TLieferavisPakets { get; set; } = new List<TLieferavisPaket>();

    public virtual ICollection<TLieferavisPosition> TLieferavisPositions { get; set; } = new List<TLieferavisPosition>();
}
