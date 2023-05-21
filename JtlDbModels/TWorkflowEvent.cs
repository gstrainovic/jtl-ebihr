using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflowEvent
{
    public int KWorkflowEvent { get; set; }

    public int NEvent { get; set; }

    public int NObjekt { get; set; }

    public string CDisplayName { get; set; } = null!;

    public int NSortierung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
