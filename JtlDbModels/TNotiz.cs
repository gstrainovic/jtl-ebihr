using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNotiz
{
    public int KNotiz { get; set; }

    public int KKunde { get; set; }

    public int? KAuftrag { get; set; }

    public string? CNotiz { get; set; }

    public int NTyp { get; set; }

    public DateTime DErstellt { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
