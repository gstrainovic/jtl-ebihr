﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDeGebErweiterungen
{
    public int KEbayDeGebErweiterungen { get; set; }

    public string? Enhancement { get; set; }

    public byte? MehrereArtikel { get; set; }

    public decimal Gebuehr { get; set; }
}
