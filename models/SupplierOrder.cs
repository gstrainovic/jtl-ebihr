using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SupplierOrder
{
    public int SupplierOrderId { get; set; }

    public int SupplierId { get; set; }

    public int? CompanyId { get; set; }

    public int? WarehouseId { get; set; }

    public int DeliveryNoteId { get; set; }

    public string? SupplierOrderNo { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string CurrencyIso { get; set; } = null!;

    public decimal CurrencyFactor { get; set; }

    public int? DropShipping { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
