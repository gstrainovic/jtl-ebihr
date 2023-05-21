using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFormular
{
    public int KFormular { get; set; }

    public int NTyp { get; set; }

    public string CName { get; set; } = null!;

    public byte NStandard { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
