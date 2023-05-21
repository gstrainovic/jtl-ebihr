using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TInetBestellungAttribute
{
    public int KInetBestellungAttribute { get; set; }

    public int KInetBestellung { get; set; }

    public int KShop { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
