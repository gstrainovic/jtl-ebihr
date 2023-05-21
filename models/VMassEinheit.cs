using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VMassEinheit
{
    public int KMassEinheit { get; set; }

    public string? CCode { get; set; }

    public string? CDisplayCode { get; set; }

    public int? KBezugsMassEinheit { get; set; }

    public decimal FBezugsMassEinheitFaktor { get; set; }
}
