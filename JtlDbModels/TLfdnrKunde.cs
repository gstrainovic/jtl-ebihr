using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLfdnrKunde
{
    public int? NNummer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
