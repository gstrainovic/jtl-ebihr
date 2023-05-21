using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TChannel
{
    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public string CJson { get; set; } = null!;

    public string CCurrency { get; set; } = null!;

    public bool NVariationsSupported { get; set; }

    public bool NRemainingQuantitySupported { get; set; }

    public bool NQuantityPriceSupported { get; set; }

    public bool NPriceUpdatesSupported { get; set; }

    public byte NInvoiceDocumentTransfer { get; set; }

    public bool NReturnTrackingRequired { get; set; }

    public bool NAllowCombineOrders { get; set; }

    public DateTime? DKategorieAktualisierungUtc { get; set; }

    public DateTime? DChannelAttributeAktualisierungUtc { get; set; }

    public virtual ICollection<TCategory> TCategories { get; set; } = new List<TCategory>();

    public virtual ICollection<TCategoryAttribute> TCategoryAttributes { get; set; } = new List<TCategoryAttribute>();

    public virtual ICollection<TChannelAttribute> TChannelAttributes { get; set; } = new List<TChannelAttribute>();

    public virtual ICollection<TChannelPriceType> TChannelPriceTypes { get; set; } = new List<TChannelPriceType>();

    public virtual ICollection<TPaymentRule> TPaymentRules { get; set; } = new List<TPaymentRule>();

    public virtual ICollection<TShippingRule> TShippingRules { get; set; } = new List<TShippingRule>();

    public virtual ICollection<TShopScx> TShopScxes { get; set; } = new List<TShopScx>();
}
