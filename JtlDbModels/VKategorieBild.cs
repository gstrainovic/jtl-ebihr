using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKategorieBild
{
    public int KKategoriebildPlattform { get; set; }

    public int KKategorie { get; set; }

    public int KPlattform { get; set; }

    public int KShop { get; set; }

    public int KBild { get; set; }

    public byte NInet { get; set; }

    public byte[] BBild { get; set; } = null!;

    public int NDateigroesse { get; set; }

    public string CHash { get; set; } = null!;
}
