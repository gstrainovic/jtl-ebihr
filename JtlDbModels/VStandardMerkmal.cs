using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStandardMerkmal
{
    public int KMerkmal { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public byte? NGlobal { get; set; }

    public string? CTyp { get; set; }

    public byte NVerwendungszweck { get; set; }

    public byte? NMehrfachauswahl { get; set; }
}
