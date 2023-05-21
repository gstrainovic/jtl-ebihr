using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VVariationMapping
{
    public int KChannel { get; set; }

    public int KShop { get; set; }

    public int KArtikel { get; set; }

    public string? VariationName { get; set; }

    public string? VariationNameMapping { get; set; }

    public string? VariationwertName { get; set; }

    public string? VariationwertNameMapping { get; set; }
}
