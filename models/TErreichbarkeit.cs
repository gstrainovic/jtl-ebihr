using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TErreichbarkeit
{
    public int KEreichbarkeit { get; set; }

    public DateTime DAnfang { get; set; }

    public DateTime? DEnde { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KAntwortkanal { get; set; }

    public virtual TAntwortkanal KAntwortkanalNavigation { get; set; } = null!;
}
