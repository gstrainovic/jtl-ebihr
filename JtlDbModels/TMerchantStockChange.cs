using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMerchantStockChange
{
    public int KMerchantStockChange { get; set; }

    public DateTimeOffset? DProcessedAt { get; set; }

    public byte NProcessingState { get; set; }

    public string CWarehouseId { get; set; } = null!;

    public string CJfsku { get; set; } = null!;

    public int NStockVersion { get; set; }

    public DateTimeOffset DTimestamp { get; set; }

    public byte NChangeType { get; set; }

    public string? CNote { get; set; }

    public string? CBatch { get; set; }

    public DateTimeOffset? DBestBefore { get; set; }

    public decimal FQuantityShippable { get; set; }

    public decimal FQuantityBlocked { get; set; }

    public decimal FQuantityReserved { get; set; }

    public decimal FQuantityAnnounced { get; set; }

    public decimal FLevelShippable { get; set; }

    public decimal FLevelBlocked { get; set; }

    public decimal FLevelReserved { get; set; }

    public decimal FLevelAnnounced { get; set; }

    public string? CInboundNumber { get; set; }

    public string? CInboundItemId { get; set; }

    public string? COutboundNumber { get; set; }

    public string? COutboundItemId { get; set; }

    public string? COutboundShippingNotificationId { get; set; }

    public string? COutboundShippingNotificationItemId { get; set; }

    public decimal? FQuantityShippableBooked { get; set; }

    public decimal? FQuantityBlockedBooked { get; set; }

    public decimal? FQuantityReservedBooked { get; set; }

    public decimal? FQuantityAnnouncedBooked { get; set; }

    public string? CReturnId { get; set; }

    public string? CReturnItemId { get; set; }
}
