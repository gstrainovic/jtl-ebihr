using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMassEinheit
{
    public int KMassEinheit { get; set; }

    public string? CCode { get; set; }

    public string? CDisplayCode { get; set; }

    public int? KBezugsMassEinheit { get; set; }

    public decimal FBezugsMassEinheitFaktor { get; set; }
}
