using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatistikVorlage
{
    public int KStatistikVorlage { get; set; }

    public int? KStatistikAuswertungstyp { get; set; }

    public int? KStatistikVorlageOrdner { get; set; }

    public int? KBenutzer { get; set; }

    public string? CName { get; set; }

    public string? CSpaltennameX { get; set; }

    public string? CSpaltennameSeries { get; set; }

    public string? CSql { get; set; }

    public string? CZeitraum { get; set; }

    public int? NSort { get; set; }

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
