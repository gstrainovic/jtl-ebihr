using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VDeletedQueue
{
    public int? KShop { get; set; }

    public string? CName { get; set; }

    public int? KWert { get; set; }

    public byte? NAction { get; set; }

    public int? KOption1 { get; set; }

    public int? KOption2 { get; set; }

    public byte NInBearbeitung { get; set; }
}
