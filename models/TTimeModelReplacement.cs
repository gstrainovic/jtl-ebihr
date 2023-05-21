using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTimeModelReplacement
{
    public int KTimeModelReplacement { get; set; }

    public int KTimeModel { get; set; }

    public int KTimeModelReplaced { get; set; }

    public DateTime DFrom { get; set; }

    public DateTime DTo { get; set; }

    public string CReason { get; set; } = null!;

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TTimeModel KTimeModelNavigation { get; set; } = null!;

    public virtual TTimeModel KTimeModelReplacedNavigation { get; set; } = null!;
}
