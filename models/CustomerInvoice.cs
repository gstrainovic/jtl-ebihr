using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerInvoice
{
    public int CustomerInvoiceId { get; set; }

    public int? CompanyHistoryId { get; set; }

    public DateTime CreationDate { get; set; }

    public string CustomerInvoiceNo { get; set; } = null!;

    public int IsPayed { get; set; }

    public decimal InvoiceCurrencyFactor { get; set; }

    public string InvoiceCurrencyIso { get; set; } = null!;

    public bool IsCancelled { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
