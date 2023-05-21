using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VConfigurationGroup
{
    public int KConfigurationGroup { get; set; }

    public string? CName { get; set; }

    public int NType { get; set; }

    public bool? NRequired { get; set; }

    public int NStatus { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
