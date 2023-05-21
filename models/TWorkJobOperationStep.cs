using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkJobOperationStep
{
    public int KWorkJobOperationStep { get; set; }

    public int KWorkJobOperation { get; set; }

    public int KOperationStep { get; set; }

    public DateTimeOffset? DStarted { get; set; }

    public DateTimeOffset? DFinished { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TOperationStep KOperationStepNavigation { get; set; } = null!;

    public virtual TWorkJobOperation KWorkJobOperationNavigation { get; set; } = null!;
}
