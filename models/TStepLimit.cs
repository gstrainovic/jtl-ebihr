using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStepLimit
{
    public int KStepLimit { get; set; }

    public int KShop { get; set; }

    public Guid BStepId { get; set; }

    public string? CStepName { get; set; }

    public int NCurrentLimit { get; set; }

    public DateTime DErrorTime { get; set; }

    public int NErrorCounter { get; set; }
}
