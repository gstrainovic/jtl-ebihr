﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelEigenschaftWertAufprei
{
    public int KKundengruppe { get; set; }

    public int KEigenschaftWert { get; set; }

    public decimal FAufpreisNetto { get; set; }

    public int KShop { get; set; }
}
