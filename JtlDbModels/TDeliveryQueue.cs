using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDeliveryQueue
{
    public int KDeliveryQueue { get; set; }

    public int KFulfillmentAuftrag { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public int NState { get; set; }

    public int NInvoiceState { get; set; }

    public int NDeliveryNoteState { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TFulfillmentAuftrag KFulfillmentAuftragNavigation { get; set; } = null!;
}
