using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkbenchBin
{
    public int KWorkbenchBin { get; set; }

    public int KWorkbenchResource { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public bool NSharedBin { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NDirection { get; set; }

    public int? KZustand { get; set; }

    public virtual TWarenLagerPlatz KWarenLagerPlatzNavigation { get; set; } = null!;

    public virtual TWorkbenchResource KWorkbenchResourceNavigation { get; set; } = null!;
}
