﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VInitialize
{
    public int KInetKunde { get; set; }

    public int KBestellung { get; set; }

    public int KInetAdresse { get; set; }

    public int KZahlungseingang { get; set; }

    public int? KShop { get; set; }
}
