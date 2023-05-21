using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReplenishmentDestination
{
    public int KAuftragPos { get; set; }

    public int KWarenlager { get; set; }

    public int? KWarenlagerBereich { get; set; }

    public int? KWarenlagerPlatz { get; set; }

    public int? KResource { get; set; }
}
