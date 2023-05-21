using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AmeiseExportvorlagefilter
{
    public int KExportVorlageFilter { get; set; }

    public int KStandardfilter { get; set; }

    public string? CName { get; set; }

    public byte NFilterArt { get; set; }

    public string? CUebersicht { get; set; }

    public string? CExt { get; set; }

    public string? CSortierSpalte { get; set; }

    public string? CSortierReihenfolge { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CExtMerkmale { get; set; }

    public string? CExtAttribute { get; set; }

    public string? CExtEigeneFelder { get; set; }
}
