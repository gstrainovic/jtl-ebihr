﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLagerbestandShop
{
    public int KShop { get; set; }

    public string CArtNr { get; set; } = null!;

    public DateTime DBestandsdatum { get; set; }

    public decimal? FAnzahl { get; set; }
}
