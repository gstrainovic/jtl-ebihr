using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseImporttypfeld
{
    public int KImportTypFeld { get; set; }

    public int KImportTyp { get; set; }

    public string? CName { get; set; }

    public string? CTable { get; set; }

    public string? CDbname { get; set; }

    public string? CDbtyp { get; set; }

    public int? NLaenge { get; set; }

    public byte NStandard { get; set; }

    public string? CStandardWert { get; set; }

    public string? CValidation { get; set; }

    public int NSort { get; set; }
}
