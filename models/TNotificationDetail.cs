using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNotificationDetail
{
    public long KNotificationDetail { get; set; }

    public long KNotification { get; set; }

    public string? CCode { get; set; }

    public string? CMessage { get; set; }

    public virtual TNotification KNotificationNavigation { get; set; } = null!;
}
