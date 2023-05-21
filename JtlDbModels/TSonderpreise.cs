using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSonderpreise
{
    public int KArtikelSonderpreis { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public decimal FNettoPreis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
