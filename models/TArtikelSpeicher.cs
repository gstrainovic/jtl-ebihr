using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelSpeicher
{
    public int KArtikel { get; set; }

    public string CNummer { get; set; } = null!;

    public byte NId { get; set; }

    public byte? NAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
