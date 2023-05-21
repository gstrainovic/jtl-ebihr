using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tartikeldownload
{
    public int KArtikel { get; set; }

    public int KDownload { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
