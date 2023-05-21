using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRmgrundKategorie
{
    public int KRmgrundKategorie { get; set; }

    public int KRmgrund { get; set; }

    public int KKategorie { get; set; }

    public byte NIstMarkiert { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
