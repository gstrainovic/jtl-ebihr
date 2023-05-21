using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VMerchantPendingStockChange
{
    public int Pk { get; set; }

    public string StockChangeIdWarehouseId { get; set; } = null!;

    public string StockChangeIdJfsku { get; set; } = null!;

    public int StockChangeIdStockVersion { get; set; }

    public DateTimeOffset? ProcessedAt { get; set; }

    public byte ProcessingState { get; set; }

    public DateTimeOffset Timestamp { get; set; }

    public byte ChangeType { get; set; }

    public string? Note { get; set; }

    public string? Batch { get; set; }

    public DateTimeOffset? BestBefore { get; set; }

    public decimal QuantityShippable { get; set; }

    public decimal QuantityBlocked { get; set; }

    public decimal QuantityReserved { get; set; }

    public decimal QuantityAnnounced { get; set; }

    public decimal LevelShippable { get; set; }

    public decimal LevelBlocked { get; set; }

    public decimal LevelReserved { get; set; }

    public decimal LevelAnnounced { get; set; }

    public string? InboundItemNumber { get; set; }

    public string? InboundItemItemId { get; set; }

    public string? OutboundItemNumber { get; set; }

    public string? OutboundItemItemId { get; set; }

    public string? OutboundShippingNotificationNumber { get; set; }

    public string? OutboundShippingNotificationItemId { get; set; }

    public decimal? QuantityBookedShippable { get; set; }

    public decimal? QuantityBookedBlocked { get; set; }

    public decimal? QuantityBookedReserved { get; set; }

    public decimal? QuantityBookedAnnounced { get; set; }

    public int WawiProductArtikelKey { get; set; }

    public string WawiProductMerchantSku { get; set; } = null!;

    public bool? WawiProductIsWarehouseActive { get; set; }

    public bool? WawiProductIsBatch { get; set; }

    public bool? WawiProductIsBestBefore { get; set; }

    public bool? WawiProductIsDivisible { get; set; }

    public bool? WawiProductIsSerialNumber { get; set; }

    public bool? WawiProductIsBillOfMaterials { get; set; }

    public decimal WawiProductNetRetailPrice { get; set; }

    public decimal? WawiStockLevelStockLevel { get; set; }

    public decimal WawiStockLevelStockLevelBlocked { get; set; }

    public int WawiStockLevelWarenlagerKey { get; set; }

    public int WawiStockLevelWarenlagerPlatzKey { get; set; }

    public int? WawiStockLevelWarenlagerPlatzBlockedKey { get; set; }

    public int? WawiInboundLieferantenBestellungKey { get; set; }

    public int? WawiInboundUmlagerungKey { get; set; }

    public int? WawiInboundBestellPosKey { get; set; }

    public int? WawiInboundStreckenlagerWarenlagerPlatzKey { get; set; }

    public int? WawiReturnRetourePosKey { get; set; }

    public int? WawiReturnRetoureKey { get; set; }
}
