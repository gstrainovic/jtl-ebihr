using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLieferschein
{
    public int KLieferschein { get; set; }

    public int KBestellung { get; set; }

    public int KBenutzer { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CHinweis { get; set; }

    public DateTime? DMailVersand { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public int? NFulfillment { get; set; }

    public int? KLieferantenBestellung { get; set; }

    public int? KSessionId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TFulfillerLieferscheinRef? TFulfillerLieferscheinRef { get; set; }

    public virtual TLieferscheinEckdaten? TLieferscheinEckdaten { get; set; }

    public virtual ICollection<TMerchantInboundShippingNotificationRef> TMerchantInboundShippingNotificationRefs { get; set; } = new List<TMerchantInboundShippingNotificationRef>();

    public virtual ICollection<TMerchantVersandRef> TMerchantVersandRefs { get; set; } = new List<TMerchantVersandRef>();

    public virtual ICollection<TOrderShipping> TOrderShippings { get; set; } = new List<TOrderShipping>();
}
