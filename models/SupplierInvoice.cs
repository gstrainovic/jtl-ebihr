using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SupplierInvoice
{
    public int SupplierInvoiceId { get; set; }

    public int? SupplierId { get; set; }

    public DateTime? CreationDate { get; set; }

    public byte? Status { get; set; }

    public string? CurrencyIso { get; set; }

    public decimal CurrencyFactor { get; set; }

    public byte? Deleted { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
