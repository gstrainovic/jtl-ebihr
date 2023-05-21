using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Teigenschaft
{
    public int KEigenschaft { get; set; }

    public int KArtikel { get; set; }

    public string? CWaehlbar { get; set; }

    public int? NSort { get; set; }

    public string CTyp { get; set; } = null!;

    public string? CAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
