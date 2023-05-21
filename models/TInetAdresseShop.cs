using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TInetAdresseShop
{
    public int KInetAdresse { get; set; }

    public int KShop { get; set; }

    public int? KAdresse { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
