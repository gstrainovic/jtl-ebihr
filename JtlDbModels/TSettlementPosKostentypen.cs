using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSettlementPosKostentypen
{
    public string CAmountType { get; set; } = null!;

    public string CAmountDescription { get; set; } = null!;

    public byte? NKostentyp { get; set; }
}
