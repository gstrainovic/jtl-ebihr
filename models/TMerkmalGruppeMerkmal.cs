using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerkmalGruppeMerkmal
{
    public int KMerkmalGruppe { get; set; }

    public int KMerkmal { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
