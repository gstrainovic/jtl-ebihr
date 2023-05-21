using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VWarenlagerPlatzArtikel
{
    public int KWarenLagerPlatz { get; set; }

    public int KArtikel { get; set; }

    public decimal? FAnzahl { get; set; }

    public string? CKommentar1 { get; set; }

    public string? CKommentar2 { get; set; }
}
