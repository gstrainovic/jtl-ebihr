using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOrder
{
    public int KOrder { get; set; }

    public string CEventId { get; set; } = null!;

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public bool NPaymentUpload { get; set; }

    public string COrderStatus { get; set; } = null!;

    public string? CPaymentMethod { get; set; }

    public string? CPaymentReference { get; set; }

    public int? KAuftrag { get; set; }

    public bool NCancellationUpload { get; set; }

    public string? COrderCancellationRequestId { get; set; }

    public bool NReturnUpload { get; set; }

    public string? CChannelReturnId { get; set; }

    public bool NInvoiceUpload { get; set; }

    public bool NInvoiceCorrectionUpload { get; set; }

    public virtual TAuftrag? KAuftragNavigation { get; set; }

    public virtual ICollection<TOrderItem> TOrderItems { get; set; } = new List<TOrderItem>();
}
