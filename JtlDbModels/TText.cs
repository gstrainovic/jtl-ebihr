using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TText
{
    public int KText { get; set; }

    public string? CName { get; set; }

    public string? CText { get; set; }

    public byte? NFontSize { get; set; }

    public string? CFontName { get; set; }

    public string? CType { get; set; }

    public string? CAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
