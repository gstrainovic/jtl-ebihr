using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseImportvorlagefilter
{
    public int KImportVorlageFilter { get; set; }

    public int KImportVorlage { get; set; }

    public string? CName { get; set; }

    public string? CTable { get; set; }

    public string? CDbname { get; set; }

    public string? CWert { get; set; }

    public byte? NOperator { get; set; }

    public string? CDbtyp { get; set; }

    public int? NLaenge { get; set; }

    public string? CValidation { get; set; }

    public int? NSpalte { get; set; }
}
