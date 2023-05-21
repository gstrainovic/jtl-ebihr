using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStuecklisteGutschriftPo
{
    public int KGutschriftPos { get; set; }

    public int? KArtikel { get; set; }

    public decimal? FAnzahl { get; set; }
}
