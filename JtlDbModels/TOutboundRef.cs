using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOutboundRef
{
    public int KOutboundRef { get; set; }

    public int? KFulfillmentAuftrag { get; set; }

    public int KBestellung { get; set; }

    public byte NType { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public string? COutboundId { get; set; }

    public string? CNote { get; set; }

    public byte? NChangeState { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public string? CWarehouseId { get; set; }

    public DateTimeOffset? DObjectVersion { get; set; }

    public virtual TAuftrag KBestellungNavigation { get; set; } = null!;

    public virtual TFulfillmentAuftrag? KFulfillmentAuftragNavigation { get; set; }
}
