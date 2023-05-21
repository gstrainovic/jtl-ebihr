using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerOrder
{
    public int CustomerOrderId { get; set; }

    public int CompanyHistoryId { get; set; }

    public string CustomerOrderType { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? SendDate { get; set; }

    public string OrderNumber { get; set; } = null!;

    public decimal? Discount { get; set; }

    public bool? IsCancled { get; set; }

    public bool? IsCompletelyDelivered { get; set; }

    public int Prio { get; set; }

    public byte OrderState { get; set; }

    public int? CustomerId { get; set; }

    public int? PlatformId { get; set; }

    public int? WebshopId { get; set; }

    public int? ShippingMethodId { get; set; }

    public string? ShipFromCountryIso { get; set; }

    public string CurrencyShipFromCountryIso { get; set; } = null!;

    public decimal CurrencyFactorShipFromCountry { get; set; }

    public decimal OrderCurrencyFactor { get; set; }

    public string? OrderCurrencyIso { get; set; }

    public int? PaymentTypeId { get; set; }

    public decimal PaymentTypeCost { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
