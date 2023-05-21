using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TInboundRef
{
    public int KInboundRef { get; set; }

    public int KLieferantenBestellung { get; set; }

    public byte NType { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public string? CInboundId { get; set; }

    public byte? NChangeState { get; set; }

    public int NRetryAttempts { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte NInboundStatus { get; set; }

    public virtual TLieferantenBestellung KLieferantenBestellungNavigation { get; set; } = null!;
}
