using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PaymentMethod
{
    public int InternalId { get; set; }

    public int? LanguageInternalId { get; set; }

    public string? Name { get; set; }

    public byte? Debit { get; set; }

    public string? PaymentOption { get; set; }

    public string? Account { get; set; }

    public byte? DeliverBeforePayment { get; set; }

    public byte Priority { get; set; }

    public byte DunningActive { get; set; }

    public decimal? CashDiscount { get; set; }

    public int? CashDiscountValidity { get; set; }
}
