﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNegotiationItem
{
    public int KNegotiationItem { get; set; }

    public int KEbayuser { get; set; }

    public int? KEbayItem { get; set; }

    public int NSiteId { get; set; }

    public DateTime DZuletztAngefordert { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KAlienItem { get; set; }

    public virtual EbayAlienitem? KAlienItemNavigation { get; set; }

    public virtual EbayItem? KEbayItemNavigation { get; set; }

    public virtual EbayUser KEbayuserNavigation { get; set; } = null!;

    public virtual EbayXxSite NSite { get; set; } = null!;
}
