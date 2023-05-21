using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerCreditNote
{
    public int CustomerCreditNoteId { get; set; }

    public int? CustomerInvoiceId { get; set; }

    public int? CompanyId { get; set; }

    public int? LanguageId { get; set; }

    public string? CurrencyIso { get; set; }

    public decimal CurrencyFactor { get; set; }

    public string? CustomerCreditNoteNo { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
