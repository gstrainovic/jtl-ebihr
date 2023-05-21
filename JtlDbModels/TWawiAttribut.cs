using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWawiAttribut
{
    public int KWawiAttribut { get; set; }

    public int KAttribut { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
