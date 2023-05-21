using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenlagerOptionenArtikelbild
{
    public int KWarenlagerOptionenArtikelbild { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public string? CCustomName { get; set; }

    public int NSprache { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
