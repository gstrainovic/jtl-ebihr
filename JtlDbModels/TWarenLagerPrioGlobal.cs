using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerPrioGlobal
{
    public int KWarenLager { get; set; }

    public int KVertriebsweg { get; set; }

    public int? NPrio { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
