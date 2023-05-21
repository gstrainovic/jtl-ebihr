using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrderFile
{
    public int KProductionOrderFile { get; set; }

    public int KProductionOrder { get; set; }

    public int KFile { get; set; }

    public string? CName { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;
}
