using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VSteuerdaten
{
    public int KSteuerzone { get; set; }

    public string? CVersandlandIso { get; set; }

    public string CZiellandIso { get; set; } = null!;

    public string CZielbundesland { get; set; } = null!;

    public int KFirma { get; set; }

    public string? CFirmaName { get; set; }

    public int? KSteuerklasse { get; set; }

    public decimal FSteuersatzErmittelt { get; set; }

    public decimal FSteuersatz { get; set; }

    public int NSteuertyp { get; set; }

    public int NIstSpezifisch { get; set; }
}
