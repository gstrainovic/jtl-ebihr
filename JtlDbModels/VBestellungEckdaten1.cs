using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellungEckdaten1
{
    public int KBestellung { get; set; }

    public decimal FWert { get; set; }

    public decimal FZahlung { get; set; }

    public decimal FGutschrift { get; set; }

    public decimal FGutschein { get; set; }

    public decimal FFaktor { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FWertNetto { get; set; }
}
