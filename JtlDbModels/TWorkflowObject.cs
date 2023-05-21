using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflowObject
{
    public int NObjekt { get; set; }

    public string CName { get; set; } = null!;

    public string CPkColumn { get; set; } = null!;
}
