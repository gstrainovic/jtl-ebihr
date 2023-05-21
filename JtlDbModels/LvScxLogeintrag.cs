using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvScxLogeintrag
{
    public int KScxLogeintrag { get; set; }

    public int KSyncLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string? CErweiterteMeldung { get; set; }

    public byte NErweiterterInhalt { get; set; }

    public int? KShop { get; set; }

    public string? CMeldung { get; set; }

    public byte NCallType { get; set; }
}
