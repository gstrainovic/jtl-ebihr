﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelBild
{
    public int KBild { get; set; }

    public byte[] BBild { get; set; } = null!;

    public int NDateigroesse { get; set; }

    public string CHash { get; set; } = null!;
}
