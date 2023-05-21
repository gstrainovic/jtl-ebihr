using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNotification
{
    public long KNotification { get; set; }

    public long? KId { get; set; }

    public string CEventId { get; set; } = null!;

    public DateTime DCreationDate { get; set; }

    public byte NSeverity { get; set; }

    public byte NType { get; set; }

    public string? CReference { get; set; }

    public bool NGelesen { get; set; }

    public int KShop { get; set; }

    public string? COrderCancellationRequestId { get; set; }

    public virtual ICollection<TNotificationDetail> TNotificationDetails { get; set; } = new List<TNotificationDetail>();
}
