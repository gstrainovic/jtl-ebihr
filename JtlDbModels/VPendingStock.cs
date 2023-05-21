using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VPendingStock
{
    public int Pk { get; set; }

    public string? Jfsku { get; set; }

    public string? WarehouseId { get; set; }

    public int KWarenlager { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityBlocked { get; set; }

    public string? Note { get; set; }

    public string? Batch { get; set; }

    public int? BestBeforeDay { get; set; }

    public int? BestBeforeMonth { get; set; }

    public int? BestBeforeYear { get; set; }

    public DateTimeOffset FulfillerTimestamp { get; set; }

    public Guid FulfillerStockChangeId { get; set; }

    public int KArtikel { get; set; }

    public int KBenutzer { get; set; }

    public int KBuchungsart { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int? KLieferantenBestellungPos { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? COwnerId { get; set; }

    public int? KSessionId { get; set; }

    public int? KWarenLagerEingang { get; set; }

    public string? CInboundId { get; set; }

    public byte NChangeState { get; set; }

    public byte? NCondition { get; set; }

    public int? KRmretourePos { get; set; }

    public byte NBlocked { get; set; }
}
