using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayCheckoutpo
{
    public int KEbayCheckoutPos { get; set; }

    public int? KEbayCheckout { get; set; }

    public string? ItemId { get; set; }

    public string? TransactionId { get; set; }

    public int? KXcheckoutPos { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FPreis { get; set; }

    public int? KArtikel { get; set; }
}
