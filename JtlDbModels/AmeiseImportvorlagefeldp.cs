using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseImportvorlagefeldp
{
    public int KImportVorlageFeldPs { get; set; }

    public int KImportVorlage { get; set; }

    public string? CTable { get; set; }

    public string? CDbname { get; set; }

    public string? CPraefix { get; set; }

    public string? CSuffix { get; set; }
}
