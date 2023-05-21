using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkProcessSearch
{
    public int KWorkProcess { get; set; }

    public string CIdentifier { get; set; } = null!;

    public byte NType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TWorkProcess KWorkProcessNavigation { get; set; } = null!;
}
