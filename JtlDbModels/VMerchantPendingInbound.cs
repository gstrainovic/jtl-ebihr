using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantPendingInbound
{
    public int KLieferantenBestellung { get; set; }

    public int? KUmlagerung { get; set; }

    public string? MerchantInboundNumber { get; set; }

    public byte[] Rowversion { get; set; } = null!;

    public string? WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public bool? IsLieferantenBestellung { get; set; }

    public DateTimeOffset? UpdatedAt { get; set; }

    public byte? ChangeType { get; set; }

    public byte? ChangeState { get; set; }

    public int? RetryAttempts { get; set; }

    public string? InboundId { get; set; }

    public byte? InboundStatus { get; set; }

    public int? LieferantenBestellungStatus { get; set; }

    public string? ExternalInboundNumber { get; set; }

    public int KLieferant { get; set; }

    public string? FirmaName { get; set; }

    public bool? LieferantenNameUebertragen { get; set; }
}
