using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tartikeldownload
{
    public int KArtikel { get; set; }

    public int KDownload { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
