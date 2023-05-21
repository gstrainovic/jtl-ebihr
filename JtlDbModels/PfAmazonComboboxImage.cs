using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonComboboxImage
{
    public int KImage { get; set; }

    public string CEnumToString { get; set; } = null!;

    public string CPk { get; set; } = null!;

    public byte[]? OImage { get; set; }

    public string? CText { get; set; }
}
