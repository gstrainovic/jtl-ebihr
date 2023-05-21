using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelEigenschaft
{
    public int KEigenschaft { get; set; }

    public int KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CWaehlbar { get; set; }

    public int? NSort { get; set; }

    public string CTyp { get; set; } = null!;

    public int KSprache { get; set; }
}
