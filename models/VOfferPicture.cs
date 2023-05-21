using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOfferPicture
{
    public int KProduct { get; set; }

    public int KShop { get; set; }

    public int NSorting { get; set; }

    public int KPicture { get; set; }

    public byte[] BPicture { get; set; } = null!;

    public string CHash { get; set; } = null!;

    public string? CScxHash { get; set; }
}
