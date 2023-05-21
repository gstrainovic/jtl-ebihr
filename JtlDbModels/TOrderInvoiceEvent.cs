using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOrderInvoiceEvent
{
    public int KOrderInvoiceEvent { get; set; }

    public int KShop { get; set; }

    public int KAuftrag { get; set; }

    public string COrderId { get; set; } = null!;

    public string CInvoiceNumber { get; set; } = null!;

    public string CChannel { get; set; } = null!;

    public string CDocumentId { get; set; } = null!;

    public DateTime DDocumentExpiresAt { get; set; }

    public byte NType { get; set; }

    public byte NCount { get; set; }
}
