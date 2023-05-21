using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SupplierOrderReminderPo
{
    public string? SupplierOrderReminderPosId { get; set; }

    public int SupplierOrderReminderId { get; set; }

    public int SupplierOrderPosId { get; set; }

    public decimal Amount { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
