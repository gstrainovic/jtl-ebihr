using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDimensionSprache
{
    public int KDimension { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TDimension KDimensionNavigation { get; set; } = null!;
}
