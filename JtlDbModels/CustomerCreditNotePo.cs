using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerCreditNotePo
{
    public int CustomerCreditNotePosId { get; set; }

    public int CustomerCreditNoteId { get; set; }

    public int? CustomerInvoicePosId { get; set; }

    public int? CustomerOrderPosId { get; set; }

    public int ProductId { get; set; }

    public decimal NetSalesPrice { get; set; }

    public decimal Discount { get; set; }

    public decimal Amount { get; set; }

    public int PartsListPosId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
