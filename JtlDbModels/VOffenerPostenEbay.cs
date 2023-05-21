using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOffenerPostenEbay
{
    public string? CItemId { get; set; }

    public int KEbayTransaction { get; set; }

    public string? CEbayBuyerUserId { get; set; }

    public string? CEbayBuyerName { get; set; }

    public string? CEbayShippingAddressName { get; set; }

    public int? KEbayCheckout { get; set; }

    public string? CEbayCheckoutVerwendungszweck { get; set; }

    public decimal FWert { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CWaehrungIso { get; set; }
}
