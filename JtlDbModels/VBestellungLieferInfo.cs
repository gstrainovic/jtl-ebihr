using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellungLieferInfo
{
    public int KBestellung { get; set; }

    public int? NLieferbarEigen { get; set; }

    public int? NLieferbar { get; set; }

    public int? NHatTeilmengen { get; set; }
}
