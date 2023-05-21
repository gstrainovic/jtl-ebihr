using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandVorlage
{
    public int KVersandVorlage { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public byte? NStandard { get; set; }

    public string? DErstellt { get; set; }

    public string? CTrennzeichen { get; set; }

    public int? NAbZeile { get; set; }

    public int? NIntKey { get; set; }

    public int? NLieferscheinNr { get; set; }

    public int? NVersandt { get; set; }

    public int? NIdentcode { get; set; }

    public int? NVersandInfo { get; set; }

    public int? NReserved { get; set; }

    public string? CDateFormat { get; set; }

    public int? KLogistik { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
