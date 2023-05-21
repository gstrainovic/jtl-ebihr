using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatus1
{
    public int KMandant { get; set; }

    public byte NAbgleichstyp { get; set; }

    public int KZiel { get; set; }

    public DateTime DZeitstempelUtc { get; set; }

    public int NStatus { get; set; }

    public string? CProgressText { get; set; }
}
