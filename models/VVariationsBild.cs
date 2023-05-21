using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VVariationsBild
{
    public int KEigenschaftWertPict { get; set; }

    public int? KEigenschaftWert { get; set; }

    public int? KPlattform { get; set; }

    public int? KShop { get; set; }

    public int? KBild { get; set; }

    public byte? NInet { get; set; }

    public byte[] BBild { get; set; } = null!;

    public int NDateigroesse { get; set; }

    public string CHash { get; set; } = null!;
}
