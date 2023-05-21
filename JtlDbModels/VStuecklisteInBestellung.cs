using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStuecklisteInBestellung
{
    public int Stueckliste { get; set; }

    public int TArtikelKArtikel { get; set; }

    public decimal? MengeInBestellung { get; set; }
}
