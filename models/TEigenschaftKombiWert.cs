using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEigenschaftKombiWert
{
    public int KEigenschaftKombi { get; set; }

    public int KEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
