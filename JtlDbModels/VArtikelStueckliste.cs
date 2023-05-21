using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelStueckliste
{
    public int KStueckliste { get; set; }

    public int KArtikel { get; set; }

    public decimal FAnzahl { get; set; }
}
