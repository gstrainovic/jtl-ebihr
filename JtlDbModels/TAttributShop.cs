using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAttributShop
{
    public int KAttribut { get; set; }

    public int KShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
