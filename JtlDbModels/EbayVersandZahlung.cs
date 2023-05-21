using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayVersandZahlung
{
    public int KEbayVersandZahlung { get; set; }

    public int KEbayUser { get; set; }

    public string COrderId { get; set; } = null!;

    public string CItemId { get; set; } = null!;

    public string CTransactionId { get; set; } = null!;

    public int NPaymentSuccessful { get; set; }

    public int NShippingSuccessful { get; set; }

    public string? CPaymentErrorMessage { get; set; }

    public string? CShippingErrorMessage { get; set; }

    public DateTime DUpdatedAt { get; set; }

    public DateTime DCreatedAt { get; set; }
}
