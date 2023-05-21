using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEigenschaftWertAufprei
{
    public int KEigenschaftWert { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public decimal FAufpreisNetto { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
