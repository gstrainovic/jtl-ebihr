﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellungLieferInfoProLager
{
    public int KBestellung { get; set; }

    public int KWarenlager { get; set; }

    public int? NLieferbarEigen { get; set; }

    public int? NLieferbar { get; set; }

    public int? NHatTeilmengen { get; set; }
}
