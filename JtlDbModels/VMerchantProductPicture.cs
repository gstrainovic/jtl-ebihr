using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantProductPicture
{
    public int KArtikelbildPlattform { get; set; }

    public int KArtikel { get; set; }

    public int KPlattform { get; set; }

    public int NNr { get; set; }

    public int KBild { get; set; }

    public byte[] BBild { get; set; } = null!;

    public byte[] BBildRowVersion { get; set; } = null!;

    public int? NFfnNumber { get; set; }

    public byte[]? BProductPictureRefBildRowVersion { get; set; }
}
