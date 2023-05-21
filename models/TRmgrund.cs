using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRmgrund
{
    public int KRmgrund { get; set; }

    public byte NAktiv { get; set; }

    public string? CColor { get; set; }

    public byte NEinschraenkung { get; set; }

    public byte? NWmsVisible { get; set; }

    public int? NSort { get; set; }

    public int NFfncode { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NFfnDefaultMapping { get; set; }

    public int? KScxreason { get; set; }

    public virtual TReturnReason? KScxreasonNavigation { get; set; }
}
