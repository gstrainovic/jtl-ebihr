using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragzahlung
{
    public int KZahlung { get; set; }

    public string? CName { get; set; }

    public decimal FBetrag { get; set; }

    public DateTime? DDatum { get; set; }

    public byte? NAnzahlung { get; set; }

    public int? KBestellung { get; set; }
}
