﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestandBestandsartikel
{
    public int KArtikel { get; set; }

    public decimal? FBestand { get; set; }

    public decimal? FBestandGesperrtFuerVerfuegbar { get; set; }

    public decimal? FBestandGesperrtFuerAuslieferung { get; set; }
}
