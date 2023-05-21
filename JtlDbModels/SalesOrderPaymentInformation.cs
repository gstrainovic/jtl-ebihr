using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SalesOrderPaymentInformation
{
    public int SalesOrderInternalId { get; set; }

    public string PaymentMethodType { get; set; } = null!;

    public string? DebitMandateReference { get; set; }

    public string? DebitCreditorId { get; set; }

    public string? DebitAccountHolder { get; set; }

    public string? DebitBank { get; set; }

    public string? DebitIban { get; set; }

    public string? DebitBic { get; set; }

    public string DebitSubject { get; set; } = null!;

    public string DebitEndToEndId { get; set; } = null!;

    public DateTime? DebitDueDate { get; set; }

    public string? PayeeAccountHolder { get; set; }

    public string? PayeeBank { get; set; }

    public string? PayeeIban { get; set; }

    public string? PayeeBic { get; set; }

    public string PayeeSubject { get; set; } = null!;

    public string PayeeEndToEndId { get; set; } = null!;

    public DateTime? PayeeDueDate { get; set; }

    public string? PaymentInfo { get; set; }

    public decimal FinancingCosts { get; set; }

    public string? TransferAccountHolder { get; set; }

    public string? TransferBank { get; set; }

    public string? TransferIban { get; set; }

    public string? TransferBic { get; set; }

    public string TransferSubject { get; set; } = null!;

    public string TransferEndToEndId { get; set; } = null!;

    public DateTime? TransferDueDate { get; set; }

    public string? PayPalId { get; set; }
}
