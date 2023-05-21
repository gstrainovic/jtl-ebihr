using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VSteuerklasse
{
    public int KSteuerklasse { get; set; }

    public string? CName { get; set; }

    public byte? NStandard { get; set; }
}
