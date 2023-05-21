using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarehouseBinDevice
{
    public int KWarehouseBinDevice { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TWarenLagerPlatz KWarenLagerPlatzNavigation { get; set; } = null!;
}
