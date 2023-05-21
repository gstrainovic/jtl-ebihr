using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragPositionIntervall
{
    public int KAuftragPosition { get; set; }

    public int KAuftrag { get; set; }

    public int NTyp { get; set; }

    public int? NIntervall { get; set; }

    public int? NIntervallTyp { get; set; }

    public DateTime? DStartdatum { get; set; }

    public DateTime? DEnddatum { get; set; }

    public DateTime? DNextFaelligkeit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftragPosition KAuftragPositionNavigation { get; set; } = null!;
}
