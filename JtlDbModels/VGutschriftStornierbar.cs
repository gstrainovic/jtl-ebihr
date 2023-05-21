using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VGutschriftStornierbar
{
    public int KGutschrift { get; set; }

    public string? CGutschriftNr { get; set; }

    public int NError { get; set; }
}
