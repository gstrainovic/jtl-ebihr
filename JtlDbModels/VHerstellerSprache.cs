using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VHerstellerSprache
{
    public int KHersteller { get; set; }

    public int KSprache { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CMetaDescription { get; set; }

    public string? CMetaKeywords { get; set; }

    public string? CMetaTitle { get; set; }

    public string? CSeo { get; set; }
}
