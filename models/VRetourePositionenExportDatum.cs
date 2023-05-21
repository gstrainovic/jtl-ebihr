using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRetourePositionenExportDatum
{
    public int KRmretoure { get; set; }

    public decimal Anzahl { get; set; }

    public string? Beschreibung { get; set; }

    public decimal? PreisGesamt { get; set; }

    public decimal? GewichtGesamt { get; set; }
}
