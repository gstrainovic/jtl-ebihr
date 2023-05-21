using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelUpload
{
    public int KArtikelUpload { get; set; }

    public int? KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CDateiTyp { get; set; }

    public int? NPflicht { get; set; }

    public int KSprache { get; set; }
}
