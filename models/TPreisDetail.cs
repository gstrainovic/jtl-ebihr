﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPreisDetail
{
    public int KPreis { get; set; }

    public int NAnzahlAb { get; set; }

    public decimal FNettoPreis { get; set; }

    public decimal FProzent { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
