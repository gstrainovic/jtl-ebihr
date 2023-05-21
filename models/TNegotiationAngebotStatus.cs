using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNegotiationAngebotStatus
{
    public int KNegotiationAngebotStatus { get; set; }

    public int? KEbayItem { get; set; }

    public string CKaeuferMaskiert { get; set; } = null!;

    public DateTime DErstellungsDatum { get; set; }

    public byte NStatus { get; set; }

    public int NDauer { get; set; }

    public string CDauerEinheit { get; set; } = null!;

    public int? KAlienItem { get; set; }

    public virtual EbayAlienitem? KAlienItemNavigation { get; set; }

    public virtual EbayItem? KEbayItemNavigation { get; set; }
}
