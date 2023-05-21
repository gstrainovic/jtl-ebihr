using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkProcessReplenishment
{
    public int KWorkProcessReplenishment { get; set; }

    public int KWorkProcess { get; set; }

    public int? KWorkProcessIteration { get; set; }

    public int? KWorkJobOperation { get; set; }

    public int KReplenishmentAuftrag { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftrag KReplenishmentAuftragNavigation { get; set; } = null!;

    public virtual TWorkJobOperation? KWorkJobOperationNavigation { get; set; }

    public virtual TWorkProcessIteration? KWorkProcessIterationNavigation { get; set; }

    public virtual TWorkProcess KWorkProcessNavigation { get; set; } = null!;
}
