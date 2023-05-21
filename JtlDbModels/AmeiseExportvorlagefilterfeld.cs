using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseExportvorlagefilterfeld
{
    public int KExportVorlageFilterFeld { get; set; }

    public int KExportVorlageFilter { get; set; }

    public string? CDbname { get; set; }

    public byte NOperator { get; set; }

    public string? CWert { get; set; }

    public string? CTable { get; set; }
}
