﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellungLieferInfoProLager1
{
    public int KBestellung { get; set; }

    public int KWarenLager { get; set; }

    public int? NLieferbarEigen { get; set; }

    public int? NLieferbar { get; set; }

    public int? NHatTeilmengen { get; set; }
}