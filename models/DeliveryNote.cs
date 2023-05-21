using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class DeliveryNote
{
    public int DeliveryNoteId { get; set; }

    public int CustomerOrderId { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? IsFulfillment { get; set; }

    public int? SupplierOrderId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
