using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SupplierOrderReminder
{
    public int SupplierOrderReminderId { get; set; }

    public int? SupplierOrderId { get; set; }

    public int? SystemUserId { get; set; }

    public DateTime? ReminderDate { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
