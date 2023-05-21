using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VWaehrung
{
    public int KWaehrung { get; set; }

    public string? CName { get; set; }

    public string CIso { get; set; } = null!;

    public string? CNameHtml { get; set; }

    public decimal FFaktor { get; set; }

    public byte? NStandard { get; set; }

    public byte? NVorBetrag { get; set; }

    public string? CTrennzeichenCent { get; set; }

    public string? CTrennzeichenTausend { get; set; }

    public int KShop { get; set; }
}
