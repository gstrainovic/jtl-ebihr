using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonSettlementpo
{
    public long KMessageId { get; set; }

    public int KUser { get; set; }

    public long SettlementId { get; set; }

    public string TransactionType { get; set; } = null!;

    public string? OrderId { get; set; }

    public string? MerchantOrderId { get; set; }

    public string? AdjustmentId { get; set; }

    public string? ShipmentId { get; set; }

    public string? MarketplaceName { get; set; }

    public string? AmountType { get; set; }

    public string? AmountDescription { get; set; }

    public decimal Amount { get; set; }

    public string? FulfillmentId { get; set; }

    public DateTime? PostedDateTime { get; set; }

    public string? OrderItemCode { get; set; }

    public string? MerchantOrderItemId { get; set; }

    public string? Sku { get; set; }

    public int? QuantityPurchased { get; set; }

    public string? PromotionId { get; set; }

    public DateTime DErstellt { get; set; }

    public virtual ICollection<TAuftragkosten> TAuftragkostens { get; set; } = new List<TAuftragkosten>();
}
