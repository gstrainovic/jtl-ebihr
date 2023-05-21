using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShippingDocument
{
    public int KShippingDocument { get; set; }

    public int KVersand { get; set; }

    public byte NTyp { get; set; }

    public byte[] BData { get; set; } = null!;

    public string CHash { get; set; } = null!;

    public DateTime DDate { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
