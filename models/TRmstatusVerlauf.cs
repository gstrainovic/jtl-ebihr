using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRmstatusVerlauf
{
    public int KRmstatusVerlauf { get; set; }

    public int KRmretourePos { get; set; }

    public int KRmstatus { get; set; }

    public string? CKommentar { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DErstellt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
