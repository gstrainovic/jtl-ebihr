﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelMedienDateiSprache
{
    public int KMedienDatei { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }
}
