using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFormularEmailEinstellung
{
    public int KFormularEmailEinstellung { get; set; }

    public int KFormular { get; set; }

    public string CBcc { get; set; } = null!;

    public byte NSignieren { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
