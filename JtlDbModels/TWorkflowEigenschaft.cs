using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflowEigenschaft
{
    public int KWorkflowEigenschaft { get; set; }

    public string CDotLiquid { get; set; } = null!;

    public string CName { get; set; } = null!;

    public int NObjekt { get; set; }

    public byte NDatenTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
