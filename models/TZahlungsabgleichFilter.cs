using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TZahlungsabgleichFilter
{
    public int KZahlungsabgleichFilter { get; set; }

    public string CBeschreibung { get; set; } = null!;

    public int KZahlungsabgleichModul { get; set; }

    public byte NUmsatzart { get; set; }

    public byte NFilterspalte { get; set; }

    public byte NFilteroperator { get; set; }

    public string CFilterwert { get; set; } = null!;

    public byte NAktion { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
