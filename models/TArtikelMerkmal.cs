﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelMerkmal
{
    public int? KMerkmal { get; set; }

    public int KMerkmalWert { get; set; }

    public int KArtikel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
