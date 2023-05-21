using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerReturn
{
    public int CustomerReturnId { get; set; }

    public int StatusId { get; set; }

    public int CustomerId { get; set; }

    public int? WarehouseId { get; set; }

    public int CompanyId { get; set; }

    public int? CustomerInvoiceCorrId { get; set; }

    public int? CustomerOrderId { get; set; }

    public string CustomerReturnNo { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
