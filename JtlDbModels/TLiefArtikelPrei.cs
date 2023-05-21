using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLiefArtikelPrei
{
    public int KLiefArtikelPreis { get; set; }

    public int KLiefArtikel { get; set; }

    public decimal FAb { get; set; }

    public decimal FPreisNetto { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NUseProzentualerRabatt { get; set; }

    public decimal FProzentualerRabatt { get; set; }
}
