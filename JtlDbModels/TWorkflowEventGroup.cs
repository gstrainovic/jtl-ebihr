using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflowEventGroup
{
    public int KWorkflowEventGroup { get; set; }

    public int NObjekt { get; set; }

    public string CDisplayName { get; set; } = null!;

    public int? NSortierung { get; set; }
}
