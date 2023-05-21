using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelbildPlattformSeo
{
    public int KArtikelbildPlattformSeo { get; set; }

    public int KArtikelbildPlattform { get; set; }

    public int KSprache { get; set; }

    public string CAlternativtext { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
