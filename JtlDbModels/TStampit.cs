using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStampit
{
    public short? NAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
