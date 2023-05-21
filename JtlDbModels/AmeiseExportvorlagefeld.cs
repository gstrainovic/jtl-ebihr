using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseExportvorlagefeld
{
    public int KExportVorlageFeld { get; set; }

    public int KExportVorlage { get; set; }

    public string? CName { get; set; }

    public string? CDbname { get; set; }

    public string? CKopfzeilenbeschriftung { get; set; }

    public int NSpalte { get; set; }
}
