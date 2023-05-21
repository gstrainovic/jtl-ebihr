using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOffenerPostenEingangsrechnungZahlung
{
    public int KZahlung { get; set; }

    public decimal FBetrag { get; set; }

    public DateTime? DDatum { get; set; }

    public int KEingangsrechnung { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public int? KLieferant { get; set; }

    public string CStandardWaehrungIso { get; set; } = null!;

    public byte NMatchingOptionen { get; set; }
}
